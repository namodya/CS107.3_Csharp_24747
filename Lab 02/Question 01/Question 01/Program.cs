using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());


            Console.Write("Please enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            {

                double sum = firstNum + secondNum;


                Console.WriteLine("\nThe sum is" + sum);
                Console.ReadKey();
            }
        }

    }


        