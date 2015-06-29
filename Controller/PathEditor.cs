using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Thrift.GameCall;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Controller
{
    public partial class PathEditor : Form
    {
        bool bWorking = false;
        public PathEditor()
        {
            InitializeComponent();
        }
        delegate void F_AddPoint(double x, double y);
        void GenPathThread()
        {
            const double StepDis = 300.0f;
            F_AddPoint addPoint = new F_AddPoint(AddPoint);
            PosInfo LastSavePos=null;
            while(bWorking)
            {
                PosInfo pPos=Program.client.GetPlayerPos();
                double dis = StepDis;
                if (LastSavePos != null)
                    dis = Func.GetDis(pPos.X, pPos.Y, LastSavePos.X, LastSavePos.Y);
                if(dis<StepDis)
                {
                    Thread.Sleep(200);
                    continue;
                }
                LastSavePos = pPos;
                addPoint(pPos.X, pPos.Y);
                Thread.Sleep(500);
            }
        }
        void AddPoint(double x, double y)
        {
            int nRow = dgbPath.Rows.Add();
         //   dgbPath.Rows[nRow].Cells[0].Value = nRow.ToString();
            dgbPath.Rows[nRow].Cells[0].Value = x.ToString();
            dgbPath.Rows[nRow].Cells[1].Value = y.ToString();
        }
        private void btnStartGenPath_Click(object sender, EventArgs e)
        {
            if(bWorking==true)
                return;
            bWorking=true;
            Thread t = new Thread(GenPathThread);
            t.IsBackground = false;
            t.Start();
        }

        private void btnStopGenPath_Click(object sender, EventArgs e)
        {
            bWorking = false;
        }

        private void btnLoadPath_Click(object sender, EventArgs e)
        {
            dgbPath.Rows.Clear();

            //string filename = @"aaaa.path";
            string filename = tbPathName.Text;
            if (filename.Length < 1)
            {
                MessageBox.Show("请输入路径文件名");
                return;
            }
            filename += ".path";

            Stream fStream = null;
            try
            {
                fStream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (Exception err)
            {
                return;
            }
            int n = 0;
            BinaryFormatter binFormat = new BinaryFormatter();
            while (true)
            {
                try
                {
                    PathPoint point = (PathPoint)binFormat.Deserialize(fStream);
                    int nRow = dgbPath.Rows.Add();
                    dgbPath.Rows[nRow].Cells[0].Value = point.x.ToString();
                    dgbPath.Rows[nRow].Cells[1].Value = point.y.ToString();

                }
                catch (Exception err)
                {
                    break;
                }
                ++n;
            }
            fStream.Close();
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            string filename = tbPathName.Text;
            if (filename.Length < 1)
            {
                MessageBox.Show("请输入路径文件名");
                return;
            }
            filename += ".path";

            Stream fStream = null;
            fStream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binFormat = new BinaryFormatter();
            PathPoint point = new PathPoint();
            for (int i = 0; i < dgbPath.Rows.Count; ++i)
            {
                
                double.TryParse(dgbPath.Rows[i].Cells[0].Value.ToString(), out point.x);
                double.TryParse(dgbPath.Rows[i].Cells[1].Value.ToString(), out point.y);
                binFormat.Serialize(fStream, point);
            }
            fStream.Close();
        }

        private void btnDelPoint_Click(object sender, EventArgs e)
        {
            try
            {
                dgbPath.Rows.Remove(dgbPath.CurrentRow);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        const double ArriveDis = 100.0f;
        void MoveThread()
        {
            //获取路径
            List<PathPoint> path = new List<PathPoint>();
            for (int i = 0; i < dgbPath.Rows.Count; ++i)
            {
                PathPoint point = new PathPoint();
                double.TryParse(dgbPath.Rows[i].Cells[0].Value.ToString(), out point.x);
                double.TryParse(dgbPath.Rows[i].Cells[1].Value.ToString(), out point.y);
                path.Add(point);
            }

            int TargetPointNum=0;
            Program.client.PressKey(87, 1);//开始走
            while(bWorking)
            {
                //获取角色位置
                PosInfo pPos = Program.client.GetPlayerPos();
                //计算距离,小于XX则切换下一个点,到达终点则退出
                double dis=Func.GetDis(path[TargetPointNum].x, path[TargetPointNum].y, pPos.X, pPos.Y);
                if(dis<ArriveDis)
                {
                    ++TargetPointNum;
                    if(TargetPointNum>=path.Count)
                    {
                        Program.client.PressKey(87,1);
                        bWorking = false;
                        break;
                    }
                }
                //调整面向角
                double angle = Func.CalcAngle(pPos.X, pPos.Y, path[TargetPointNum].x, path[TargetPointNum].y);
                Program.client.ChangeAngle(angle);
                Thread.Sleep(200);
            }
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            AddPoint(100, 200);
        }

        private void btnStopMove_Click(object sender, EventArgs e)
        {
            bWorking = false;
        }

        private void btnReversePath_Click(object sender, EventArgs e)
        {
            List<PathPoint> path = new List<PathPoint>();
            for(int i=0;i<dgbPath.Rows.Count;++i)
            {
                PathPoint point = new PathPoint();
                double.TryParse(dgbPath.Rows[i].Cells[0].Value.ToString(), out point.x);
                double.TryParse(dgbPath.Rows[i].Cells[1].Value.ToString(), out point.y);
                path.Add(point);
            }

            path.Reverse();
            dgbPath.Rows.Clear();
            foreach(var item in path)
            {
                int nRow = dgbPath.Rows.Add();
                dgbPath.Rows[nRow].Cells[0].Value = item.x.ToString();
                dgbPath.Rows[nRow].Cells[1].Value = item.y.ToString();
            }

        }

        private void btnClearPath_Click(object sender, EventArgs e)
        {
            dgbPath.Rows.Clear();
        }
    }
    [Serializable]
    class PathPoint
    {
        public double x=0;
        public double y=0;
    }
}
