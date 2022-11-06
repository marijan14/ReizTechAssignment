using System;

namespace ClockAngle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the hours: ");
                var hours = int.Parse(Console.ReadLine());

                Console.Write("Enter the minutes: ");
                var minutes = int.Parse(Console.ReadLine());

                var angle = ClockAngle(hours, minutes);
                Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {angle} degrees");
            }
            catch(Exception ex) when (ex is ArgumentOutOfRangeException || ex is FormatException)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private static double ClockAngle(int hours, int minutes)
        {
            if (hours > 12 || hours < 0 || minutes > 60 || minutes < 0)
                throw new ArgumentOutOfRangeException("Hours can be between the range of 1 and 12 and minutes can be between the range of 0 and 60");

            return Math.Abs(0.5 * (60 * hours - 11 * minutes));
        }
    }
}
