using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handling
{
    internal class application_exeption
    {
        public class AgeException : Exception
        {
            //constructor                     call parent class ctor
            public AgeException(string error) : base(error)
            {

            }
        }
        public class User
        {
            public User(int age)
            {
                if (age < 18)
                {
                    throw new AgeException("You can not vote");
                }
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    User user1 = new User(17);
                }
                catch (AgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
