using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    internal class Circle
    {
        //Attributes
        private double Radius;

        //Methods
        //SetRadius method
        public void SetRadius(double r)
        {
            Radius = r; //Set radius so the to string will display the correct value
            if (r > 0)
            {
                
                throw new InvalidRadiusException();
            }
            else throw new InvalidRadiusException(r);
        }

        //ToString method
        public override string ToString()
        {
            return $"Circle radius is {Radius}.";
        }
    }
}
