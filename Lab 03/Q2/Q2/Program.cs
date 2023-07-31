using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CountVowels(string input)
            {
                int count = 0;
                string vowels = "aeiouAEIOU";

                foreach (char c in input)
                {
                    if (vowels.Contains(c))
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
   








        }
}
}
