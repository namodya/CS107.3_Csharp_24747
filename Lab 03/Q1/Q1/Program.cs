﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
                Console.WriteLine("Odd");
            Console.ReadLine();
        }
    }
}
