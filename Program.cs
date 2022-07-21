using System;

namespace OurFirstOwnClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object of my class/ an instance of Hooman:
            Hooman magda = new Hooman();
            //access public variable from outside and even change it:
            magda.firstName = "Magda";
            //activating ("calling") methods of the class (here of the object "magda"):
            magda.introduceMyself();

            //creating a 2nd object
            Hooman michael = new Hooman();
            michael.firstName = "Michael";
            michael.introduceMyself();

            Console.Read();
        }
    }
}
