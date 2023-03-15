using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    internal class Program //Main class
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Circle c1 = new Circle();
            Circle c2 = new Circle();

            //Creating objects to test code
            try
            {
                c.SetRadius(1.23);
            }
            catch (InvalidRadiusException)
            {
                Console.WriteLine(c.ToString());                
            }           
            try
            {
                c1.SetRadius(-4.56);
            }
            catch (InvalidRadiusException)
            {
                Console.WriteLine(c1.ToString());
            }
            try
            {
                c2.SetRadius(0.00);
            }
            catch (InvalidRadiusException)
            {
                Console.WriteLine(c2.ToString());
            }

            //Keep program running
            Console.ReadKey();
        }
    }
}
