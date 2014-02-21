using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm_AHP;
using BPNet;

namespace BPAHP
{
    public class BPAdjustedNode:BasicNode
    {
        public BPAdjustedNode(string nodeName)
            : base(nodeName)
        { 
        }

        /// <summary>
        /// 通过BP调整一致性
        /// </summary>
        /// <param name="CRLimit"></param>
        protected override void AdjustConsistency(double CRLimit)
        {
            if (this.GetConsistency() <= CRLimit) return;

            #region BP调整一致性

            #region 构造bp训练的输入/输出数据
            int matrixDimension = this.matrix.GetLength(0);
            SortedDictionary<string, double> dictInput = new SortedDictionary<string, double>();
            SortedDictionary<string, double> dictOutput = new SortedDictionary<string, double>();
            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = i + 1; j < matrixDimension; j++)
                {
                    if (null == this.matrix[i, j])
                    {
                        throw new NullJudgmentMatrixException("无法将空的判断矩阵交给BP神经网络进行一致性调整");
                    }

                    if (this.matrix[i, j].DoubleValue <= 1)
                    {
                        dictInput.Add(i + "_" + j, this.matrix[i, j].DoubleValue);
                        dictOutput.Add(i + "_" + j, this.matrix[i, j].DoubleValue);
                    }
                    else
                    {
                        dictInput.Add(j + "_" + i, this.matrix[j, i].DoubleValue);
                        dictOutput.Add(j + "_" + i, this.matrix[j, i].DoubleValue);
                    }
                }
            }

            double[,] bpInput = new double[dictInput.Count, 1];
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
            int dimension1 = 0, dimension2 = 0;
            foreach (string key in dictInput.Keys)
            {
                GetIndexByKey(key, ref dimension1, ref dimension2);
                SetMatrixElement(dimension1, dimension2, predictResult[index++, 0]);
            }

            Console.WriteLine();

            #endregion

            base.CalculatePriorities();
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
        /// 设置判断矩阵的元素值，同时更改其对称元素的值
        /// </summary>
        /// <param name="dimension1"></param>
        /// <param name="dimension2"></param>
        /// <param name="value"></param>
        private void SetMatrixElement(int dimension1, int dimension2, double value)
        {
            this.matrix[dimension1, dimension2].DoubleValue = value;
            this.matrix[dimension2, dimension1] = new Fraction(this.matrix[dimension1, dimension2]).Exchange();

        }
    }
}
