using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_AHP
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

    public class NotEqualLengthException : Exception
    {
        const string exceptionMessage = "长度不相等错误";

        public NotEqualLengthException(string message) :
            base(string.Format("{0}-{1}", exceptionMessage,message))
        {
        }
    }

    public class NullConfigurationItemException : Exception
    {
        const string exceptionMessage = "配置项不存在";

        public NullConfigurationItemException(string message) :
            base(string.Format("{0}-{1}", exceptionMessage, message))
        {
        }
    }
}
