using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    abstract partial class WorkFlow
    {
        //回城函数
        //更新
        public virtual FRet Update()
        {
            return FRet.Success;
        }
        //攻击
    }

}
