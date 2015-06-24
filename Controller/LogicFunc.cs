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
    class Func
    {
        public static double CalcAngle(Pos pPos, Pos tPos)
        {
            double temp1 = (tPos.Y - pPos.Y);
            double temp2 = (tPos.X - pPos.X);
            double angle = Math.Atan2(temp1, temp2);
            if (angle < 0)
                angle += 2 * 3.14159266;

            if (angle < 3.1415926)
                angle = 3.1415926 - angle;
            else
                angle = 7.8539816 - angle;
            return angle;
        }
        public static double GetDis(double tx, double ty, double px, double py)
        {
            double x = Math.Abs(tx - px);
            double y = Math.Abs(ty - py);
            return Math.Sqrt(x * x + y * y);
        }
        public static double GetDis(Pos a, Pos b)
        {
            double x = Math.Abs(a.X - b.X);
            double y = Math.Abs(a.Y - b.Y);
            return Math.Sqrt(x * x + y * y);
        }
        public static double GetDir(Pos center, Pos end)
        {
            double temp1 = (end.Y - center.Y);
            double temp2 = (end.X - center.X);
            double dir = Math.Atan2(temp1, temp2);
            if (dir < 0)
                dir += 2 * 3.14159266;
            return dir;
        }
    }
}
