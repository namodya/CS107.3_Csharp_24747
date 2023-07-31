using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary");
            double salary=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax rate");
            double taxrate=double.Parse(Console.ReadLine());

            double salAfter_tax =  salary * (1 - taxRate);
            Console.WriteLine("Salary after tax is:" + salary);

           
        }
    }
}
