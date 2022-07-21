using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstOwnClass
{
    // this class is a blueprint for a datatype:
    internal class Hooman
    {
        //member variable:
        public string firstName;

        //member method:
        public void introduceMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName}");
        }
    }
}
