using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    internal class InvalidRadiusException : Exception
    {
        //No argument constructor
        public InvalidRadiusException() 
        {
            Console.WriteLine("Valid circle radius: Circle radius is greater than zero.");
        }

        //Second constructor
        public InvalidRadiusException(double Radius)
        {
            Console.WriteLine("Invalid circle radius: " + Radius + " is not greater than zero.");
        }

    }
}
