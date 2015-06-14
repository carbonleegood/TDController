using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public enum FRet
    {
        Fail,
        Success,
        DealScript,//继续执行脚本

    }
    public class ScriptRet
    {
        public ScriptRet()
        {
            Ret = FRet.Success;
            StopAfterMission = false;
        }
        public FRet Ret{get;set;}
        public bool StopAfterMission { get; set; }
    }
    //常量

    //配置文件
    class ConfigData
    {
        public ConfigData()
        {
            LootMissionMode = true;
        }
        public bool LootMissionMode { get;set;}//循环任务模式

        public List<string> MissionScript = new List<string>();//要执行的任务脚本
    }
    class RuntimeData
    {
       //角色信息
       //怪物列表
       //战利品列表
       //箱子列表
       //门列表
    }
    //运行期数据结构
    class GlobeData
    {
        public bool Working { set; get; }

        public Dictionary<string,WorkFlow> AllScript=new Dictionary<string,WorkFlow>();//全部脚本

        public int CurMissionNum { get; set; }//当前执行的任务脚本序号
    }
    //

    //角色
    //怪物
    //
}
