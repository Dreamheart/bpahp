using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_AHP
{
    /// <summary>
    /// 支持多层次的AHP方法
    /// </summary>
    class MultiLayersAHP
    {
        int layerCount = 0;
        BasicNode targetNode = null;    //目标层节点
        BasicNode[] planNodes = null;   //方案层节点

        Dictionary<string,BasicNode> ruleNodes = null;   //准则层节点

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="layerCount">AHP层数，包含目标层、准则层、方案层</param>
        public MultiLayersAHP(int layerCount)
        {
            this.layerCount = layerCount;
            this.targetNode = new BasicNode("目标");
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="layerCount">AHP层数，包含目标层、准则层、方案层</param>
        /// <param name="_targetName">目标层节点名称</param>
        public MultiLayersAHP(int layerCount, string _targetName)
        {
            this.layerCount = layerCount;
            this.targetNode = new BasicNode(_targetName);
        }

        public void Create()
        {
            //Step1:构造下层节点数组
            BasicNode[] downNodes = null;

            //Step2：获得下层节点判断矩阵
            Fraction[,] downMatrix = null;
            
            //Step3：设置下层关联节点            
            this.targetNode.SetDownLinkedNodes(downNodes, downMatrix);
        }

    }
}
