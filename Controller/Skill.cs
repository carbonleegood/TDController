using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift;
using Thrift.GameCall;
using System.Threading;
namespace Controller
{
   class KeyPos
   {
       public const int kUnuse = -1;
       public const int k1 = 1;
       public const int k2 = 2;
       public const int k3 = 3;
       public const int k4 = 4;
       public const int k5 = 5;
       public const int kQ = 6;
       public const int kE = 7;
       public const int kR = 8;
       public const int kT = 9;
       public const int kG = 10;
       public const int k6 = 11;
       public const int k7 = 12;
       public const int k8 = 13;
       public const int k9 = 14;
       public const int k0 = 15;
       public const int kC1 = 16;
       public const int kC2 = 17;
       public const int kC3 = 18;
       public const int kC4 = 19;
       public const int kC5 = 20;
       public const int kF1 = 21;
       public const int kF2 = 22;
       public const int kF3 = 23;
       public const int kF4 = 24;
       public const int kF5 = 25;
      //     public const int k = ;
   }

     [Serializable]
    enum SkillType
    {
         BaseSkill,
    }
    ////基本技能信息
    [Serializable]
    class SingleSkill
    {
        //名称
        public string name=null;
        //技能ID
        public int id=0;
        //类型
        public SkillType type=SkillType.BaseSkill;
        //技能按键
        public int key = KeyPos.kUnuse;
        //释放距离
        public int cast_dis=-1;
        //CD时间
        public int cool_down_sec=-1;//冷却秒数
    }

    [Serializable]
    class UseSkill
    {
        //名称
        public string name = null;
        //技能按键
        public int key = 0;
    }
    //class SkillCastStep
    //{
    //    //技能释放步骤
    //    void Cast()
    //    {
    //        //都需要干什么 
    //    }
    //}
    ////组合技能
    class GroupSkill
    {
        public int CastKey = 0;//判断技能是否可放
        List<SingleSkill> SkillCastStep;
        int beginCount;
        int step;
        int curStep;
        int nextStep;

        public int  CompleteCast()//完成施放
        {
            curStep = 0;
            nextStep = 0;
            beginCount = 0;
            return 0;
        }
        public int Cast()
        {
            int count=System.Environment.TickCount;
            if (beginCount == 0)//施放第一步
            {
                Program.client.PressKey(SkillCastStep[0].key, 0);
                curStep = 1;
                nextStep = 2;
                beginCount = count;
                return 1;
            }
            int diff=count-beginCount;

            //diff-Step[0];
            //diff-Step[1];

         //   if(diff<0)
           

            //计算步骤
            //时间超过,直接返回
            if (diff>totalTime)
            {
                CompleteCast();
                return Cast_Complete;//正常施放完成0
            }
                //没有意外
            if(step==nextStep)
            {
                curStep=step;
                nextStep++;
                Program.client.PressKey(SkillCastStep[step-1].key,0);
                return step;//正常施放
            }
            else if(step==curStep)
            {
                //等待100毫秒返回
                Thread.Sleep(100);
                return step;//正常施放
            }
            return Cast_Fail;//施放失败-1
            //有意外
        }
    }

    ////所有职业技能列表
    abstract class ProfessionSkill
    {
        List<SingleSkill> AllSkill;

        public abstract void InitProfessionSkill();
        //{
        //    //读取本职业的基本技能
        //    //从游戏里读取已学技能
        //    //做对比,有的设置为可用
        //    //从配置文件里读取不用技能

        //    //将使用技能设置到相应按键上

        //    //组合技能部分
        //    //初始化所有组合技能
        //    //去掉不可用技能
        //    //生成技能列表

        //}
        public abstract void UpdateSkill();
     //   GroupSkill GetSkill();
    }
    class 天香技能 : ProfessionSkill
    {
        public int SkillKey;//技能的可释放信息,bit0-bit14有效
        public override void InitProfessionSkill()
        {
            Dictionary<string,SingleSkill> tempskill=new Dictionary<string,SingleSkill>();
            //基本技能反序列化

            List<SkillInfo> learnedSkillList=Program.client.GetLearnedSkillInfo();
            foreach(var item in learnedSkillList)
            {
                string skillname="";
                if (tempskill.ContainsKey(skillname) == false)
                    continue;
                //可用的技能,ID赋值
                tempskill[skillname].id = item.SkillID;
            }
            //设置不使用技能
            //tempskill

            //获取按键槽
            List<SlotSkillInfo> slot=Program.client.GetSlotSkillInfo();
            //将技能放到槽上
            foreach(var item in tempskill)
            {
                if (item.Value.key == -1)//不使用的技能
                    continue;
                Program.client.MoveSkillToSlot(item.Value.id,slot[item.Value.key].SlotAddr);
            }

            //组合技部分-------------------------------------------------------------------------------------

            //    //初始化所有组合技能
           
            //    //去掉不可用技能
            
            //    //生成技能列表
            
            //判断INT值,优先级

            //0-24BIT来判断
            //键位，持续时间，步骤
            List<GroupSkill> groupSkillList;

          
        }
        public override void UpdateSkill()
        {
            SkillKey=0;
            List<int> SkillReleaseList=Program.client.GetSkillReleaseInfo();
            for(int i=0;i<15;++i)
            {
                if (SkillReleaseList[i] == 1)
                    SkillKey |= 1 << i;

            }
        }
        GroupSkill GetCastSkill()
        {
            GroupSkill retSkill = null;
            List<GroupSkill> groupSkillList;
             foreach(var item in groupSkillList)
            {
                //判断可施放
                int Key= item.CastKey & SkillKey;
                if (Key==0)
                {
                    retSkill=item;
                    break;
                }
            }
             return retSkill;
        }
    }
}
