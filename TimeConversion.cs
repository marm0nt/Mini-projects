using System;

namespace Timeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount of time in minutes only");
            int totalTimeInMinutes = int.Parse(Console.ReadLine());
            int hours = totalTimeInMinutes / 60;
            int remainingMinutes = totalTimeInMinutes % 60;


            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", totalTimeInMinutes,hours,remainingMinutes);




        }
    }
}
