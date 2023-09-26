using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 0;

            try
            {

                int c = a / b;
                Console.WriteLine($"division is {c}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
