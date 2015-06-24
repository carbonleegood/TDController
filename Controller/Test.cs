using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Thrift.GameCall;
namespace Controller
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private bool bWorking = false;
        //int MoveToPoint(Pos tPos)
        //{
        //    Pos pPos = getplayerpos();

        //    double dis = GetDis(pPos, tPos);
        //    if (dis < 100.0)
        //        return 0;
        //    Program.client.PressKey(w, keydown);
        //    for (int i = 0; i < 20; ++i)
        //    {
        //        //获取角色当前坐标
        //        pPos = getplayerpos();
        //        double dis=GetDis(pPos, tPos);
        //        if (dis < 100.0)
        //        {
        //            Program.client.PressKey(w, keyup);
        //            break;
        //        }
        //        double angle=Func.CalcAngle(pPos, tPos);
        //        Program.client.ChangeAngle(angle);
        //      //  ChangeToTargetAngle(pPos, tPos);
        //        //按W
        //        Thread.Sleep(200);
        //    }
        //}
        MonsterInfo SearchNearestMonster(Pos pPos, List<MonsterInfo> monsterList)
        {
            MonsterInfo NearMonster = null;
            // double dis = 1000.0;
            double nearestDis = 1000.0;
            foreach (var item in monsterList)
            {
                if (item.HP < 1)
                    continue;
                double dis = Func.GetDis(pPos.X, pPos.Y, item.X, item.Y);
                if (dis < nearestDis)
                {
                    NearMonster = item;
                    nearestDis = dis;
                }
            }
            return NearMonster;
        }
        private void WorkThread()
        {
            while (bWorking)
            {
                //获取角色信息
                PlayerInfo player = Program.client.GetPlayerInfo();
                Pos pPos = new Pos(player.X, player.Y);
                //     UpdatePlayerInfo();
                //血量少的话喝药

                //如果离打怪点远,回来


                //获取怪物信息
                List<MonsterInfo> monsterlist = Program.client.GetMonsterList();
                Pos tPos = new Pos();
                MonsterInfo monster = SearchNearestMonster(pPos, monsterlist);
                if (monster == null)
                {
                    Thread.Sleep(200);
                    continue;
                }

                double angle = CalcAngle(pPos.X, pPos.Y, monster.X, monster.Y);
                Program.client.ChangeAngle(angle);
                Program.client.PressKey(49, 0);
                Thread.Sleep(100);
                //     UpdateMonsterInfo();
                //搜索怪物
                //5码内有怪物则攻击

                //走到怪物处

            }
        }
        private void btnStartWork_Click(object sender, EventArgs e)
        {
            if (bWorking == true)
                return;
            Thread t = new Thread(WorkThread);
            t.IsBackground = true;
            bWorking = true;
            t.Start();
        }

        private void btnStopWork_Click(object sender, EventArgs e)
        {
            bWorking = false;
            Thread.Sleep(500);
        }
        //double GetDis(double tx, double ty, double px, double py)
        //{
        //    double x = Math.Abs(tx - px);
        //    double y = Math.Abs(ty - py);
        //    return Math.Sqrt(x * x + y * y);
        //}
        //double GetDis(Pos a,Pos b)
        //{
        //    double x=Math.Abs(a.X-b.X);
        //    double y=Math.Abs(a.Y-b.Y);
        //    return Math.Sqrt(x * x + y * y);
        //}
        //double GetDir(Pos center,Pos end)
        //{
        //    double temp1 = (end.Y - center.Y);
        //    double temp2 = (end.X - center.X);
        //    double dir = Math.Atan2(temp1, temp2);
        //    if (dir < 0)
        //        dir += 2 * 3.14159266;
        //    return dir;
        //}
        Pos CalcAttackPos(Pos BasePos,Pos MonsterPos)
        {
            Pos Target=new Pos();
            double dis = Func.GetDis(BasePos, MonsterPos);
            dis += 5;
            double dir = Func.GetDir(BasePos, MonsterPos);
            double ylen =Math.Abs( Math.Sin(dir) * dis);
            double xlen = Math.Abs(Math.Cos(dir) * dis);

            if (dir >= 0 && dir < 1.57)
            {
                Target.X = BasePos.X + xlen;
                Target.Y = BasePos.Y + ylen;
            }
            else if (dir >= 1.57 && dir < 3.1415926)
            {
                Target.X = BasePos.X - xlen;
                Target.Y = BasePos.Y + ylen;
            }
            else if (dir >= 3.1415926 && dir < 4.7123889)
            {
                Target.X = BasePos.X - xlen;
                Target.Y = BasePos.Y - ylen;
            }
            else if (dir >= 4.7123889)//4象限
            {
                Target.X = BasePos.X + xlen;
                Target.Y = BasePos.Y - ylen;
            }
            return Target;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pos b = new Pos(0,0);
            Pos m = new Pos(-1,5);
            Pos t=CalcAttackPos(b,m);
            MessageBox.Show(t.X.ToString()+" "+t.Y.ToString());
          //  Program.client.Test(0,0);
        }
        private void btnGetPlayerInfo_Click(object sender, EventArgs e)
        {
            PlayerInfo player = Program.client.GetPlayerInfo();
            tb1.Text = player.X.ToString();
            tb2.Text = player.Y.ToString();

            sbyte[] bname = player.Name.ToArray();
            byte[] bytes = new byte[bname.Length];
            Buffer.BlockCopy(bname, 0, bytes, 0, bname.Length);
            string strName = Encoding.Unicode.GetString(bytes);

            lsResult.Items.Clear();
            lsResult.Columns.Clear();
            lsResult.Columns.Add("name");
            lsResult.Columns.Add("Level");
            lsResult.Columns.Add("HP");
            lsResult.Columns.Add("MaxHP");
            lsResult.Columns.Add("X");
            lsResult.Columns.Add("Y");

            var SubItem = lsResult.Items.Add(strName);
            SubItem.SubItems.Add(player.Level.ToString());
            SubItem.SubItems.Add(player.HP.ToString());
            SubItem.SubItems.Add(player.MaxHP.ToString());

            SubItem.SubItems.Add(player.X.ToString());
            SubItem.SubItems.Add(player.Y.ToString());
        }
        private void btnGetPlayerPos_Click(object sender, EventArgs e)
        {
            PlayerInfo player = Program.client.GetPlayerInfo();
            tb3.Text = player.X.ToString();
            tb4.Text = player.Y.ToString();
        }
        private void btnMonsterList_Click(object sender, EventArgs e)
        {
            List<MonsterInfo> monsterlist = Program.client.GetMonsterList();

            lsResult.Items.Clear();
            lsResult.Columns.Clear();
            lsResult.Columns.Add("name");
            lsResult.Columns.Add("Level");
            lsResult.Columns.Add("HP");
            lsResult.Columns.Add("友好");
            lsResult.Columns.Add("X");
            lsResult.Columns.Add("Y");

            foreach (var item in monsterlist)
            {
                sbyte[] bname = item.Name.ToArray();
                byte[] bytes = new byte[bname.Length];
                Buffer.BlockCopy(bname, 0, bytes, 0, bname.Length);
                string strName = Encoding.Unicode.GetString(bytes);
                var SubItem = lsResult.Items.Add(strName);

                SubItem.SubItems.Add(item.Level.ToString());
                SubItem.SubItems.Add(item.HP.ToString());
                SubItem.SubItems.Add(item.Frd.ToString());

                SubItem.SubItems.Add(item.X.ToString());
                SubItem.SubItems.Add(item.Y.ToString());
            }
        }
        private void btnGetNearbyMonster_Click(object sender, EventArgs e)
        {
            PlayerInfo player = Program.client.GetPlayerInfo();
            Pos pPos = new Pos(player.X, player.Y);

            List<MonsterInfo> monsterlist = Program.client.GetMonsterList();

            lsResult.Items.Clear();
            lsResult.Columns.Clear();
            lsResult.Columns.Add("name");
            lsResult.Columns.Add("Level");
            lsResult.Columns.Add("HP");
            lsResult.Columns.Add("友好");
            lsResult.Columns.Add("X");
            lsResult.Columns.Add("Y");
            Pos tPos = new Pos();
            foreach (var item in monsterlist)
            {
                tPos.X = item.X;
                tPos.Y = item.Y;
                double dis = Func.GetDis(pPos, tPos);
                if (dis > 1000.0)
                    continue;
                sbyte[] bname = item.Name.ToArray();
                byte[] bytes = new byte[bname.Length];
                Buffer.BlockCopy(bname, 0, bytes, 0, bname.Length);
                string strName = Encoding.Unicode.GetString(bytes);
                var SubItem = lsResult.Items.Add(strName);

                SubItem.SubItems.Add(item.Level.ToString());
                SubItem.SubItems.Add(item.HP.ToString());
                SubItem.SubItems.Add(item.Frd.ToString());

                SubItem.SubItems.Add(item.X.ToString());
                SubItem.SubItems.Add(item.Y.ToString());
            }
        }

        private void btnChangeAngle_Click(object sender, EventArgs e)
        {
            double angle=0;
            if(double.TryParse(tb1.Text,out angle)==false)
            {
                MessageBox.Show("参数错误");
                return;
            }
            Program.client.ChangeAngle(angle);
        }

        private void btnEnterGame_Click(object sender, EventArgs e)
        {
            Program.client.EnterGame(0);
        }

        private void btnAutoMove_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double.TryParse(tb1.Text, out x);
            double.TryParse(tb2.Text, out y);
            Program.client.FindPath(x,y);
        }
        double CalcAngle(double px,double py,double tx,double ty)
        {
            double temp1 = (ty - py);
            double temp2 = (tx - px);
            double angle = Math.Atan2(temp1, temp2);
            if (angle < 0)
                angle += 2 * 3.14159266;

            if (angle < 3.1415926)
                angle = 3.1415926 - angle;
            else
                angle = 7.8539816 - angle;
            return angle;
        }
        private void btnChangeAngleToTarget_Click(object sender, EventArgs e)
        {
            //向目标转向,P1 P2人物坐标,P3 P4目标坐标
            //double px = 237852;
            //double py = 155621;
            //double tx = 237852;
            //double ty = 155390;
            //double tx = 237852;
            //double ty = 155621;
            //double px = 237852;
            //double py = 155390;
            double px = 0;
            double py = 0;
            //double tx = 0;
            //double ty = 0;
            double tx = 238149.0;
            double ty = 154996.0;
            double.TryParse(tb1.Text, out px);
            double.TryParse(tb2.Text, out py);
            //double.TryParse(tb3.Text, out tx);
            //double.TryParse(tb4.Text, out ty);
           
            double angle=CalcAngle(px, py, tx, ty);
            Program.client.ChangeAngle(angle);
            tb4.Text = angle.ToString();
        }

        private void btnGetSkillList_Click(object sender, EventArgs e)
        {
            Program.client.GetSkillInfo();
        }

        private void btnLCSlot_Click(object sender, EventArgs e)
        {
            int key = 0;
            int.TryParse(tb1.Text, out key);
            Program.client.LeftPressSlot(key);
        }

        private void btnRCSlot_Click(object sender, EventArgs e)
        {
            int key = 0;
            int.TryParse(tb1.Text, out key);
            Program.client.RightPressSlot(key);
        }

        private void btnPressKey_Click(object sender, EventArgs e)
        {
            int key = 0;
            int.TryParse(tb1.Text, out key);
            int up = 0;
            int.TryParse(tb2.Text, out up);
            Program.client.PressKey(key, up);
        }

        private void btnClickKey_Click(object sender, EventArgs e)
        {
            int key = 0;
            int.TryParse(tb1.Text, out key);
            int ctrl=0;
            int.TryParse(tb2.Text, out ctrl);
            Program.client.ClickKey(key,ctrl);
        }
#region 路径采集器
        private void btnStartGenPath_Click(object sender, EventArgs e)
        {

        }
        

#endregion
        private void btnCalcDis_Click(object sender, EventArgs e)
        {
            Pos a = new Pos();
            Pos b = new Pos();
            double.TryParse(tb1.Text, out a.X);
            double.TryParse(tb2.Text, out a.Y);
            double.TryParse(tb3.Text, out b.X);
            double.TryParse(tb4.Text, out b.Y);

            double dis = Func.GetDis(a, b);
            tb4.Text = dis.ToString();
        }

      

   

 

    }
}
