using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double division = num1/num2;
            double multiplication=num1* num2;

            Console.WriteLine("The sum is:" + sum);
            Console.WriteLine("The substraction is:" + sub);
            Console.WriteLine("The division is:" + division);
            Console.WriteLine("The multiplication is:" + multiplication);

            Console.ReadLine();

        }
    }
}
