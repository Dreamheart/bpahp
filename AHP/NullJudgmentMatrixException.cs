using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AHP
{
    public class NullJudgmentMatrixException:Exception
    {
        const string exceptionMessage = "判断矩阵为空";

        public NullJudgmentMatrixException(string message):
            base(string.Format("{0}-{1}",exceptionMessage,message))
        {
            //this.Message = "尚未加载判断矩阵";
        }
    }
}
