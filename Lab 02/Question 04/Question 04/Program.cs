using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num=int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("The number you have entered is an even number");

            else
                Console.WriteLine("The number you have entered is an odd number");

            Console.ReadLine();

        }
    }
}
