using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_AHP
{
    /// <summary>
    /// BasicNode可以表示目标层节点、方案层节点和准则层节点
    /// 目标层：节点只有向下关联节点
    /// 准则层：节点既有向上关联节点，又有向下关联节点
    /// 方案层：节点只有向上关联节点
    /// </summary>
    class BasicNode
    {
        string nodeName = "";   //节点名称
        Fraction[,] matrix = null;  //存储判断矩阵
        BasicNode[] downLinkedNodes = null; //存储对节点有贡献的下层节点的引用
        List<BasicNode> upLinkedNodes = new List<BasicNode>();  //存储受本节点贡献的上层节点的引用
        Dictionary<string, double> priorities = new Dictionary<string, double>();   //存储计算后的下层节点对本节点的贡献度
        double priorityToTarget = 0;    //本节点对目标节点的贡献

        /// <summary>
        /// 构造函数
        /// </summary>
        public BasicNode(string _nodeName)
        {
            this.nodeName = _nodeName;
        }

        /// <summary>
        /// 存储有贡献的下层节点的引用
        /// </summary>
        /// <param name="_linkedNodes">有贡献的下层节点数组</param>
        public void SetDownLinkedNodes(BasicNode[] _linkedNodes, Fraction[,] _matrix)
        {
            if (_linkedNodes.Length != _matrix.GetLength(0))
            {
                throw new NotEqualLengthException("判断矩阵的维度与关联节点数量不相等");
            }
            else if (_matrix.GetLength(0) != _matrix.GetLength(1))
            {
                throw new NotEqualLengthException("判断矩阵的维度行数不等于列数");
            }

            this.downLinkedNodes = new BasicNode[_linkedNodes.Length];
            for (int i = 0; i < this.downLinkedNodes.Length; i++)
            {
                this.downLinkedNodes[i] = _linkedNodes[i];  //存储节点引用
                _linkedNodes[i].AddUpLinkedNodes(this); //存储节点引用

                this.priorities[_linkedNodes[i].nodeName] = 0;  //初始化该节点对本节点的贡献度
            }

            this.matrix = Fraction.CloneFractionMatrix(_matrix);
        }

        /// <summary>
        /// 获取直接下层节点的引用
        /// </summary>
        /// <returns></returns>
        public BasicNode[] GetDownLinkedNodes()
        {
            if ( null == this.downLinkedNodes)
            {
                return new BasicNode[0];
            }

            return this.downLinkedNodes;
        }

        /// <summary>
        /// 添加受本节点贡献的上层节点的引用
        /// </summary>
        /// <param name="_upLinkedNode"></param>
        public void AddUpLinkedNodes(BasicNode _upLinkedNode)
        {
            this.upLinkedNodes.Add(_upLinkedNode);
        }

        /// <summary>
        /// 获取直接上层节点的引用
        /// </summary>
        /// <returns></returns>
        public BasicNode[] GetUpLinkedNodes()
        {
            return this.upLinkedNodes.ToArray();
        }

        /// <summary>
        /// 计算下层各节点对本节点的贡献度
        /// </summary>
        public void CalculatePriorities() 
        {
            if ( null == this.matrix )
            {
                Console.WriteLine(string.Format("系统信息：节点“{0}”不存在下层直接关联节点，无判断矩阵，故跳过计算贡献度", this.nodeName));
                return;
            }

            int indexCount = this.matrix.GetLength(0);

            //拷贝原始矩阵
            Fraction[,] judgmentMatrix = Fraction.CloneFractionMatrix(this.matrix);

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

            //this.columnSums[nodeIndex] = columnSum;

            //Step 2
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
            
            //存储贡献度
            string[] keys = this.priorities.Keys.ToArray<string>();
            int pvindex = 0;
            foreach (string key in keys)
            {
                this.priorities[key] = pv[pvindex++];
            }
        }

        /// <summary>
        /// 计算本节点对目标层的总贡献
        /// 对于方案层来说就是计算方案对目标的贡献
        /// </summary>
        public void CalculateTargetPriority()
        {
            BasicNode[] upNodes = this.GetUpLinkedNodes();
            double totalPriority = 0;
            foreach (BasicNode iterNode in upNodes)
            {
                double element = iterNode.PriorityToTarget;
                if (iterNode.GetUpLinkedNodes().Length == 0)
                {
                    element = 1;
                }
                totalPriority += iterNode.priorities[this.NodeName] * element;
            }           

            this.priorityToTarget = totalPriority;
        }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName{
            get{
                return this.nodeName;
            }
        }

        /// <summary>
        /// 本节点对目标节点的贡献
        /// </summary>
        public double PriorityToTarget {
            get 
            {
                return this.priorityToTarget;
            }
        }
    }
}
