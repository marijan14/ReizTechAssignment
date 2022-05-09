using System;

namespace _1___Clock_Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findClockAngle(3, 15));
            Console.ReadKey();
        }

        static int findClockAngle(int hour, int minute)
        {
            hour %= 12;

            int h = (hour * 360) / 12 + (minute * 360) / (12 * 60);

            int m = (minute * 360) / 60;

            int clockAngle = Math.Abs(h - m);

            if (clockAngle > 180)
                clockAngle = 360 - clockAngle;

            return clockAngle;
        }
    }
}
