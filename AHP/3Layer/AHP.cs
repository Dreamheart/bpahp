﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Algorithm_AHP
{
    public class BasicAHP
    {
        private int DataColumnBeginIndex = 1;
        private DataSet originAHPDataSet = null;
        private DataSet adjustedAHPDataSet = null;
        LayerDescription[] layers;
        int[] layerStructure;
        //{1,3,2}
        public BasicAHP(int[] layerDescirption)
        {
            this.layerStructure = layerDescirption;
            this.layers = new LayerDescription[layerDescirption.Length-1];
            for (int i = 0; i < layerDescirption.Length - 1; i++)
            {
                this.layers[i] = new LayerDescription(layerDescirption[i],layerDescirption[i+1]);
            }
        }

        public void SetJudgmentMatrix(DataSet dsMatrix)
        {
            if (null == dsMatrix)
            {
                throw new NullJudgmentMatrixException("无法将空的判断矩阵交给AHP决策");
            }
            this.originAHPDataSet = dsMatrix;
            int i = 0;
            int seqNo = 0;
            while (i < layerStructure.Length - 1)
            {
                for (int j = 0; j < layerStructure[i]; j++)
                {
                    this.SetJudgmentMatrix(i, j, DataTableToMatrix(dsMatrix.Tables[seqNo++]));
                }
                i++;
            }
        }

        /// <summary>
        /// 调整判断矩阵的一致性
        /// </summary>
        public void AdjustConsistency()
        {
            foreach (LayerDescription layer in layers)
            {
                layer.AdjustConsistency_BP();
            }
        }

        public DataSet GetAdjustedMatrix()
        {
            this.adjustedAHPDataSet = this.originAHPDataSet.Copy();
            int i = 0;
            int seq = 0;
            while (i < layerStructure.Length - 1)
            {
                for (int j = 0; j < layerStructure[i]; j++)
                {
                    MatrixToDataTable(seq++, this.GetAdjustedMatrix(i, j));
                }
                i++;
            }

            return this.adjustedAHPDataSet;
        }

        public double[] Assessment()
        {
            double[] result = new double[this.layerStructure[2]];
            for (int level3Index = 0; level3Index < this.layerStructure[2]; level3Index++)
            {
                List<double> listLeft, listRight;
                listLeft = new List<double>();
                listRight = new List<double>();
                double sum = 0;

                for (int level2Index = 0; level2Index < this.layerStructure[1]; level2Index++)
			    {
                    for (int level1Index = 0; level1Index < this.layerStructure[0]; level1Index++)
			        {
                        listLeft.Add(this.layers[1].GetPriorityVectorOfMatrix(level2Index)[level3Index]);
                        listRight.Add(this.layers[0].GetPriorityVectorOfMatrix(level1Index)[level2Index]);
			        }
			    }
                for (int i = 0; i < listLeft.Count; i++)
                {
                    sum += listLeft[i] * listRight[i];
                }

                result[level3Index] = sum;
                Console.WriteLine("Total Value: {0}", sum);
            }
            return result;
        //Outter = 0
        //    this.layers[1].GetPriorityVectorOfMatrix(0)[0] * this.layers[0].GetPriorityVectorOfMatrix(0)[0]
        //+   this.layers[1].GetPriorityVectorOfMatrix(1)[0] * this.layers[0].GetPriorityVectorOfMatrix(0)[1]
        //+   this.layers[1].GetPriorityVectorOfMatrix(2)[0] * this.layers[0].GetPriorityVectorOfMatrix(0)[2]

        //Outter = 1
        //    this.layers[1].GetPriorityVectorOfMatrix(0)[1] * this.layers[0].GetPriorityVectorOfMatrix(0)[0]
        //+   this.layers[1].GetPriorityVectorOfMatrix(1)[1] * this.layers[0].GetPriorityVectorOfMatrix(0)[1]
        //+   this.layers[1].GetPriorityVectorOfMatrix(2)[1] * this.layers[0].GetPriorityVectorOfMatrix(0)[2]

        }

        private void SetJudgmentMatrix(int layerIndex, int nodeIndex, Fraction[,] matrix)
        {
            layers[layerIndex].SetNodeMatrix(nodeIndex, matrix);
        }

        private Fraction[,] GetAdjustedMatrix(int i, int j)
        {
            return this.layers[i].GetAdjustedMatrix(j);
        }

        private DataTable MatrixToDataTable(int nodeIndex,Fraction[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = DataColumnBeginIndex; j < matrix.GetLength(1) + DataColumnBeginIndex; j++)
                {
                    this.adjustedAHPDataSet.Tables[nodeIndex].Rows[i][j] = matrix[i, j-DataColumnBeginIndex].GetDisplayValue();
                }   
            }
            return this.adjustedAHPDataSet.Tables[nodeIndex];
        }

        private Fraction[,] DataTableToMatrix(DataTable dataTable)
        {
            int dimision = dataTable.Rows.Count;
            Fraction[,] matrix = new Fraction[dimision, dimision];
            for (int i = 0; i < dimision; i++)
            {
                for (int j = DataColumnBeginIndex; j < dimision + DataColumnBeginIndex; j++)
                {
                    matrix[i, j - DataColumnBeginIndex] = new Fraction(dataTable.Rows[i][j].ToString());
                }
            }
            return matrix;
        }
    }
}
