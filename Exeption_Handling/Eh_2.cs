using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handling
{
    public class Eh_2
    {
        static void Main(string[] args)
        {
            int a = 2, b = 2;

            try
            {

                int c = a / b;
                Console.WriteLine($"division is {c}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside the finally block");
            }
        }

    }
}
