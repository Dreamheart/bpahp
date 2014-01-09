using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BPNet;

namespace AHP
{
    class LayerDescription
    {
        private readonly double[] RI = new double[]{ 0, 0, 0.58, 0.9, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49 };
        private int layerNodeCount;
        private Fraction[][,] layerNodeMatrix;
        private Fraction[][,] layerNodeMatrixBPAdjustConsistency;
        private Fraction[][,] layerNodeMatrixCompletelyConsistency;
        private int matrixDimension;
        private double[][] priorityVector;

        private double[][] columnSums;

        public LayerDescription(int layerNodeCount, int matrixDimension)
        {
            this.layerNodeCount = layerNodeCount;
            this.layerNodeMatrix = new Fraction[layerNodeCount][,];
            this.layerNodeMatrixBPAdjustConsistency = new Fraction[layerNodeCount][,];
            this.layerNodeMatrixCompletelyConsistency = new Fraction[layerNodeCount][,];
            this.matrixDimension = matrixDimension;
            for (int i = 0; i < layerNodeCount; i++)
            {
                this.layerNodeMatrix[i] = new Fraction[matrixDimension, matrixDimension];
            }
            this.priorityVector = new double[layerNodeCount][];
            this.columnSums = new double[layerNodeCount][];
        }

        /// <summary>
        /// 设置本层次指定准则的判断矩阵
        /// </summary>
        /// <param name="nodeIndex">准则在本层次中的索引</param>
        /// <param name="judgmentMatrix">判断矩阵</param>
        public void SetNodeMatrix(int nodeIndex, Fraction[,] judgmentMatrix)
        {
            this.layerNodeMatrix[nodeIndex] = this.CloneFractionMatrix( judgmentMatrix);
            this.layerNodeMatrixBPAdjustConsistency[nodeIndex] = this.CloneFractionMatrix(judgmentMatrix);

           // AdjustConsistency_BP(nodeIndex);

            this.priorityVector[nodeIndex] = GetPriorityVector(nodeIndex,this.layerNodeMatrix[nodeIndex]);

            this.layerNodeMatrixCompletelyConsistency[nodeIndex] = GetCompletelyConsistencyMatrix(this.layerNodeMatrix[nodeIndex]);

            Console.WriteLine("NodeIndex:{0}, CR:{1}",nodeIndex,GetConsistency(nodeIndex));

            //AdjustConsistency_BP(nodeIndex);
        }

        /// <summary>
        /// 根据原始矩阵，获取完全一致性矩阵
        /// </summary>
        /// <param name="originMatrix">原始矩阵</param>
        /// <returns>完全一致性矩阵</returns>
        private Fraction[,] GetCompletelyConsistencyMatrix(Fraction[,] originMatrix)
        {
            int dimension = originMatrix.GetLength(0);
            Fraction[,] result = new Fraction[dimension, dimension];

            double[] sum_A_nl = new double[dimension];

            for (int i = 0; i < dimension; i++)
            {
                sum_A_nl[i] = 0;
                for (int j = 0; j < dimension; j++)
			    {
                    sum_A_nl[i] += originMatrix[i, j].DoubleValue;
			    }
                
            }


            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    result[i, j] = new Fraction(sum_A_nl[i] / sum_A_nl[j]);
                }
            }

            return result;
        }


        /// <summary>
        /// 获取本层次中某个准则的判断矩阵的一致性比例CR
        /// </summary>
        /// <param name="nodeIndex">准则在本层次的索引</param>
        /// <returns></returns>
        public double GetConsistency(int nodeIndex)
        {
            if (this.matrixDimension < 3) //若判断矩阵维度为1或2则无需一致性检验
            {
                return 0;
            }
            else
            {
                double ci = 0;
                for (int i = 0; i < this.matrixDimension; i++)
                {
                    ci += this.columnSums[nodeIndex][i] * this.priorityVector[nodeIndex][i];
                }

                ci = (ci - this.matrixDimension) / (this.matrixDimension - 1);

                return ci / RI[matrixDimension - 1];
            }
        }

        /// <summary>
        /// 通过BP神经网络调整本层各准则的判断矩阵一致性
        /// </summary>
        public void AdjustConsistency_BP()
        {
            for (int i = 0; i < layerNodeCount; i++)
            {
                this.AdjustConsistency_BP(i);
            }
        }

        /// <summary>
        /// 通过BP神经网络调整本层指定准则的判断矩阵一致性
        /// </summary>
        /// <param name="nodeIndex"></param>
        private void AdjustConsistency_BP(int nodeIndex)
        {
            //若判断矩阵的维度小于等于2维，则符合一致性无需调整
            int dimentionOfNodeMatrix = this.layerNodeMatrix[nodeIndex].GetLength(0);
            if (dimentionOfNodeMatrix <= 2)
            {
                return;
            }

            #region 构造bp训练的输入/输出数据
            SortedDictionary<string,double> dictInput = new SortedDictionary<string,double>();
            SortedDictionary<string, double> dictOutput = new SortedDictionary<string, double>();
            for (int i = 0; i < this.matrixDimension; i++)
			{
			    for (int j = i+1; j < this.matrixDimension; j++)
			    {
                    if (null == this.layerNodeMatrix[nodeIndex][i,j])
                    {
                        throw new NullJudgmentMatrixException("无法将空的判断矩阵交给BP神经网络进行一致性调整");
                    }

    			    if( this.layerNodeMatrix[nodeIndex][i,j].DoubleValue <= 1 )
                    {
                        dictInput.Add( i+"_"+j,this.layerNodeMatrix[nodeIndex][i,j].DoubleValue);
                        dictOutput.Add(i + "_" + j, this.layerNodeMatrixCompletelyConsistency[nodeIndex][i, j].DoubleValue);
                    }
                    else
	                {
                        dictInput.Add( j+"_"+i,this.layerNodeMatrix[nodeIndex][j,i].DoubleValue);
                        dictOutput.Add(j + "_" + i, this.layerNodeMatrixCompletelyConsistency[nodeIndex][j, i].DoubleValue);
	                }
			    }
			}

            double[,] bpInput = new double[dictInput.Count,1];
            double[,] bpOutput = new double[dictOutput.Count, 1];
            int index = 0;
            foreach (string key in dictInput.Keys)
            {
                bpInput[index, 0] = dictInput[key];
                bpOutput[index++, 0] = dictOutput[key];
            }
            #endregion

            BasicBP bpn = new BasicBP();
            bpn.SetTrainInput(bpInput);
            bpn.SetTrainOutput(bpOutput);

            bpn.init();
            int study = 0;
            do
            {
                study++;
                bpn.train();
            } while (bpn.e > 0.001 && study < 50000);

            Console.WriteLine("经过 " + study + "次学习： 均方差为 " + bpn.e);

            bpn.SaveBPNet();

            bpn.SetPredictInput(bpInput);
            double[,] predictResult = bpn.PredictData();

            //根据BP运算结果调整判断矩阵
            index = 0;
            int dimension1 =0 , dimension2 =0 ;
            foreach (string key in dictInput.Keys)
            {
                GetIndexByKey(key,ref dimension1, ref dimension2);
                SetBPConsistencyMatrix(nodeIndex,dimension1, dimension2, predictResult[index++, 0]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 设置本层指定准则判断矩阵的指定元素的值
        /// </summary>
        /// <param name="nodeIndex">准则索引</param>
        /// <param name="dimension1">矩阵元素行</param>
        /// <param name="dimension2">矩阵元素列</param>
        /// <param name="value">元素值</param>
        private void SetBPConsistencyMatrix(int nodeIndex,int dimension1, int dimension2, double value)
        {
            this.layerNodeMatrixBPAdjustConsistency[nodeIndex][dimension1, dimension2].DoubleValue = value;
            this.layerNodeMatrixBPAdjustConsistency[nodeIndex][dimension2, dimension1] = new Fraction(this.layerNodeMatrixBPAdjustConsistency[nodeIndex][dimension1, dimension2]).Exchange();

        }

        /// <summary>
        /// 解析字符串如“1_2”返回1，2
        /// </summary>
        /// <param name="key">传入字符串</param>
        /// <param name="dimension1">接收X返回值</param>
        /// <param name="dimension2">接收Y返回值</param>
        private void GetIndexByKey(string key, ref int dimension1, ref int dimension2)
        {
            dimension1 = Convert.ToInt32(key.Split('_')[0]);
            dimension2 = Convert.ToInt32(key.Split('_')[1]);
        }

        /// <summary>
        /// 获取判断矩阵的优先级向量PV
        /// </summary>
        /// <param name="nodeIndex"></param>
        /// <returns></returns>
        public double[] GetPriorityVectorOfMatrix(int nodeIndex)
        {
            return this.priorityVector[nodeIndex];
        }

        /// <summary>
        /// 获取本层次准则的数量
        /// </summary>
        /// <returns></returns>
        public int GetNodeCount()
        {
            return this.layerNodeCount;
        }

        /// <summary>
        /// 计算准则的优先级向量PV
        /// </summary>
        /// <param name="nodeIndex">准则的索引</param>
        /// <param name="judgmentMatrix">判断矩阵</param>
        /// <returns></returns>
        private double[] GetPriorityVector(int nodeIndex, Fraction[,] _judgmentMatrix)
        {
            int indexCount = _judgmentMatrix.GetLength(0);

            //拷贝原始矩阵
            Fraction[,] judgmentMatrix = this.CloneFractionMatrix(_judgmentMatrix);

            //////////////////////////////////////////////////////////
            //Step 1
            double[] columnSum = new double[indexCount];
            for (int i = 0; i < indexCount; i++)
            {
                double sum = 0;
                for (int j = 0; j < indexCount; j++)
                {
                    sum += judgmentMatrix[j, i].DoubleValue;
                }
                columnSum[i] = sum;
            }

            this.columnSums[nodeIndex] = columnSum;

            //Step 2
            //TODO:此处修改了原始矩阵，需要对原始矩阵进行拷贝保护
            for (int i = 0; i < indexCount; i++)
            {
                for (int j = 0; j < indexCount; j++)
                {
                    judgmentMatrix[i, j].DoubleValue /= columnSum[j];
                }
            }
            //Step 3 
            double[] pv = new double[indexCount];
            for (int i = 0; i < indexCount; i++)
            {
                double averagePV = 0;
                for (int j = 0; j < indexCount; j++)
                {
                    averagePV += judgmentMatrix[i, j].DoubleValue;
                }
                pv[i] = averagePV / indexCount;
            }
            //////////////////////////////////////////////////////////

            return pv;
        }

        /// <summary>
        /// 创建判断矩阵副本
        /// </summary>
        /// <param name="src">需要复制的判断矩阵</param>
        /// <returns>判断矩阵的副本</returns>
        private Fraction[,] CloneFractionMatrix(Fraction[,] src)
        {
            //拷贝原始矩阵
            int length1 = src.GetLength(0);
            int length2 = src.GetLength(1);

            Fraction[,] dest = new Fraction[length1, length2];
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    dest[i, j] = new Fraction(src[i, j]);
                }
            }
            return dest;
        }

        /// <summary>
        /// 获取经过BP神经网络调整好的判断矩阵
        /// </summary>
        /// <param name="nodeIndex"></param>
        /// <returns></returns>
        internal Fraction[,] GetAdjustedMatrix(int nodeIndex)
        {
            return this.layerNodeMatrixBPAdjustConsistency[nodeIndex];
        }
    }
}
