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

namespace Controller
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private bool bWorking = false;
        private void WorkThread()
        {
            while(bWorking)
            {
                //获取角色信息
           //     UpdatePlayerInfo();
                //血量少的话喝药

                //如果离打怪点远,回来

                //获取怪物信息
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
        double GetDis(Pos a,Pos b)
        {
            double x=Math.Abs(a.X-b.X);
            double y=Math.Abs(a.Y-b.Y);
            return Math.Sqrt(x * x + y * y);
        }
        double GetDir(Pos center,Pos end)
        {
            double temp1 = (end.Y - center.Y);
            double temp2 = (end.X - center.X);
            double dir = Math.Atan2(temp1, temp2);
            if (dir < 0)
                dir += 2 * 3.14159266;
            return dir;
        }
        Pos CalcAttackPos(Pos BasePos,Pos MonsterPos)
        {
            Pos Target=new Pos();
            double dis = GetDis(BasePos, MonsterPos);
            dis += 5;
            double dir = GetDir(BasePos,MonsterPos);
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
            Program.client.GetPlayerInfo();
        }
        private void btnMonsterList_Click(object sender, EventArgs e)
        {
            Program.client.GetMonsterList();
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

      


    }
}
