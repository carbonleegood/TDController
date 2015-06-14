using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.client.Test(0,0);
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
