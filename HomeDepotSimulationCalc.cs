using System;

namespace Pb4Lecture._01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int per_square_foot = 5;

            
            Console.WriteLine("What is the length of your room?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your room?");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int price = area * per_square_foot;




            Console.WriteLine("Awesome the price of your {0} by {1} is ${2}", length, width, price);

           
           




            
            
            


        }
    }
}
