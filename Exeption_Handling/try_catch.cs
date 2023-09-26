using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exeption_Handling
{
    internal class try_catch
    {
           //Accept a name from user & if name is empty or null then raise an exception ‘name is required’ (write all code in main method)

           // (try & catch block must be in main method)

        static void Main(string[] args)
        {
            try
            {
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("name is required");
                }
                Console.WriteLine(str);
            }
            catch (Exception ex)
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
