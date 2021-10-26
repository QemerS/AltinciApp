using System;

namespace AltinciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a c# program that takes the radius of a circle as input
             * and calculate perimeter (l=2*pi*r)
             * and area (S=pi*r^2) of the circle
            */
            Console.WriteLine("Enter the radius of a circle");
            double r = Convert.ToDouble(Console.ReadLine());

            double l = 2 * Math.PI * r;
            double S = Math.PI * r * r;

            Console.WriteLine("Perimeter of circle is {0:0.00}", l);
            Console.WriteLine("Area of circle is {0:0.00}", S);
        }
    }
}
