using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._0_General
{
    class ClockAngleProblem
    {
        //https://www.geeksforgeeks.org/calculate-angle-hour-hand-minute-hand/

        //static void Main()
        //{

        //}

        //O(1) time complexity
        //O(1) space
        static int CalculateAngleBetweenHourandMinuteHand(int h, int m)
        {
            //validate input 
            if(h < 0 || m < 0 || h > 12 || m > 60)
            {
                return -1;
            }

            if (h == 12) h = 0;
            if (m == 60) m = 0;

            //calculate angles per minute
            int hour_angle_per_minute = (int)(0.5 * (h * 60 + m));
            int min_angle_per_minute = (int)(6 * m);

            //calculate the different between hands
            int angle = Math.Abs(hour_angle_per_minute - min_angle_per_minute);

            //take the min angle
            angle = Math.Min(360 - angle, angle);

            return angle;

        }

    }
}
