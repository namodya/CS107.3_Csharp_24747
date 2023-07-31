using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;  i > 0; i++)
            {
                Console.WriteLine("Enter the numbers");
                int num=int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    int sum = num + num;

                    Console.WriteLine("The sum is :" + sum);
                    Console.ReadLine();
                }
             Console.ReadLine();    
            }
            
        }
    }
}
