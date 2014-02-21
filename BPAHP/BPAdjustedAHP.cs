using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm_AHP;
using System.Data;

namespace BPAHP
{
    public class BPAdjustedAHP:MultiLayersAHP
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="config"></param>
        /// <param name="matrixs"></param>
        public BPAdjustedAHP(AHPSolution config, DataSet matrixs)
            : base(config, matrixs)
        {
 
        }

        /// <summary>
        /// 覆盖父类类型生成方法
        /// </summary>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        protected override BasicNode NewNode(string nodeName)
        {
            return new BPAdjustedNode(nodeName);
        }

        
    }
}
