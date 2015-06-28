using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift;
using Thrift.GameCall;
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
      //      const int k = ;
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
    //class GroupSkill
    //{
    //    int ID;//判断单体技能是否可放

    //    List<int> SkillCastStep;
    //    int Steps { get; set; }
    //    public void Cast(int step);
    //}

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
        public override void InitProfessionSkill()
        {
            Dictionary<string,SingleSkill> tempskill=new Dictionary<string,SingleSkill>();

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

            //组合技部分

        }
        public override void UpdateSkill()
        {

        }
    }
}
