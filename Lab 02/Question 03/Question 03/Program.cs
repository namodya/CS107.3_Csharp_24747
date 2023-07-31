using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius value:");
            double r = double.Parse(Console.ReadLine());

            double PI = 3.147;
            double area = PI * r * r;
            Console.WriteLine("The area is:" + area);

            double circumference = 2 * r * 2;
            Console.WriteLine("The circumference:");
            Console.ReadLine();
        }
    }
}
