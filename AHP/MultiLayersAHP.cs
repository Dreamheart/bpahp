using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Algorithm_AHP
{
    /// <summary>
    /// 支持多层次的AHP方法
    /// </summary>
    public class MultiLayersAHP
    {
        AHPSolution config = null;
        DataSet matrixs = null;
        int layerCount = 0;
        int DataColumnBeginIndex = 1;
        BasicNode targetNode = null;    //目标层节点
        BasicNode[] planNodes = null;   //方案层节点

        Dictionary<string,BasicNode> Nodes = new Dictionary<string,BasicNode>();   //节点集合

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="layerCount">AHP层数，包含目标层、准则层、方案层</param>
        public MultiLayersAHP(AHPSolution config,DataSet matrixs)
        {
            this.config = config;
            this.matrixs = matrixs;
            this.layerCount = int.Parse(config.GetConfigItem("TotalLayers", "4"));
            this.DataColumnBeginIndex = int.Parse(config.GetConfigItem("DataColumnBeginIndex", "1"));
            this.Create();
        }

        /// <summary>
        /// 自目标层根节点，以广度优先方式遍历AHP树，建立AHP树的节点和数据
        /// </summary>
        private void Create()
        {
            Queue<string> travelNodes = new Queue<string>();
            travelNodes.Enqueue(config.GetConfigItem("TargetName", "目标"));

            #region 创建方案节点
            string[] planNodeNames = this.config.GetConfigItem("PlanNames").Split(';');
            this.planNodes = new BasicNode[planNodeNames.Length];
            int it = 0;
            foreach (string item in planNodeNames)
            {
                if (this.config.IsExsitItem(item)) travelNodes.Enqueue(item);
                planNodes[it++] = NoRepeatAdd(item);
            }
            #endregion

            BasicNode iterNode = null;
            BasicNode[] downNodes = null;
            string iterName = "";
            while (travelNodes.Count > 0) {                               
                //广度优先遍历
                iterName = travelNodes.Dequeue();
                //Step0: 创建节点
                iterNode = NoRepeatAdd(iterName);
                if (!this.config.IsExsitItem(iterName))
                {
                    //若当前节点不存在子节点配置，说明当前节点是最底层的准则层
                    downNodes = this.planNodes;
                }
                else
                {
                    string[] downLinkedNodeNames = this.config.GetConfigItem(iterName).Split(';');
                    //Step1:构造下层节点数组
                    downNodes = new BasicNode[downLinkedNodeNames.Length];
                    int i = 0;
                    foreach (string item in downLinkedNodeNames)
                    {
                        if (!travelNodes.Contains(item))
                        {
                            travelNodes.Enqueue(item);
                        }                        
                        downNodes[i++] = NoRepeatAdd(item);
                    }
                }
                
                //Step2：获得下层节点判断矩阵
                Fraction[,] downMatrix = DataTableToMatrix(this.matrixs.Tables[iterName]);

                //Step3：设置下层关联节点
                iterNode.SetDownLinkedNodes(downNodes, downMatrix);
                            
            }

            //记录目标节点引用
            this.targetNode = NoRepeatAdd(config.GetConfigItem("TargetName", "目标"));
        }

        /// <summary>
        /// 计算每个节点收到来自直接下层关联节点的贡献，并以字典的形式存放在该节点内
        /// </summary>
        public void CalculatePriorities()
        {
            //广度优先遍历辅助队列
            Queue<BasicNode> travelQueue = new Queue<BasicNode>();

            //目标节点如队列作为遍历的起点
            travelQueue.Enqueue(this.targetNode);
            BasicNode iterNode = null;
            while (travelQueue.Count>0)
            {
                iterNode = travelQueue.Dequeue();
                iterNode.CalculatePriorities();
                foreach (BasicNode subNode in iterNode.GetDownLinkedNodes())
                {
                    if (!travelQueue.Contains(subNode)) travelQueue.Enqueue(subNode);
                }
            }

        }

        /// <summary>
        /// 向节点集合添加节点，若同名节点已经存在则不重复添加
        /// </summary>
        /// <param name="item"></param>
        /// <param name="basicNode"></param>
        private BasicNode NoRepeatAdd(string item)
        {
            if ( ! this.Nodes.ContainsKey(item))
            {
                this.Nodes.Add(item, new BasicNode(item)); 
            }
            return this.Nodes[item];
        }

        /// <summary>
        /// 将Datatable转化为Fraction判断矩阵
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
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
