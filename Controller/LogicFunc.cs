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
    }
}
