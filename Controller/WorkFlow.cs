using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    abstract partial class WorkFlow
    {
        virtual public void InitWorkData() { }//默认的实现
        abstract public ScriptRet DoWork();
    }
    //简易脚本工作流
    class SimpleScriptWorkFlow : WorkFlow
    {
        public virtual void 设置数据() { }
        public virtual void 脚本过程() { }
        public override void InitWorkData()
        {
            设置数据();
        }
        FRet BaseLogic()
        {
            return FRet.DealScript;
        }
        public override ScriptRet DoWork() 
        {
            ScriptRet ret=new ScriptRet();
            while(Program.gdata.Working)
            {
            //基本逻辑
                //更新数据
                //FRet Ret = Update();
                //if (Ret != FRet.Success)
                //{
                //    //抛出更新失败异常
                //    ret.Ret = FRet.Fail;
                //    break;
                //}
                FRet Ret = BaseLogic();
                if (Ret != FRet.DealScript)
                    continue;
            //执行脚本
                脚本过程();
            }
            return ret;
        }
    }

    //复杂脚本工作流
    //class AdvancedScriptWorkFlow : WorkFlow
    //{

    //}
    //辅助模式工作流
}
