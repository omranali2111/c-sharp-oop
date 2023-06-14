using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercise 2: Creating a Circle Class
Create a Circle class with the following properties:
Radius(double)
Implement the default constructor and a parameterized 
constructor that takes the radius as a parameter. Additionally,
implement a method to calculate and return the area of the circle.
*/
namespace c_sharp_oop
{
    public class Circle
    {
        public double Radius;
        public Circle() { }
        public Circle(double Radius) 
        
        { 
            this.Radius = Radius;
            calcRadius(Radius);
        }
        public void calcRadius(double Radius)
        {
            this.Radius = Math.PI * Radius * Radius;

            Console.WriteLine("the area of the circle is {0}", this.Radius);
        }

    }
}
