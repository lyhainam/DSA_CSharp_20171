using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex
{
    class Complex
    {
        public double real;
        public double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Declare which operator to overload (+)
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        // Declare which operator to overload (-)
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }

        // Declare which operator to overload (*)
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }

        // Declare which operator to overload (/)
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex((c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary), (c1.imaginary * c2.real - c1.real * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary));
        }

        // Declare which method to take the square root of a complex number
        public static Complex Sqrt(Complex c1)
        {
            double x, y;
            x = Math.Sqrt((c1.real + Math.Sqrt(c1.real * c1.real + c1.imaginary * c1.imaginary)) / 2);
            y = Math.Sqrt((-c1.real + Math.Sqrt(c1.real * c1.real + c1.imaginary * c1.imaginary)) / 2);
            return new Complex(x, y);
        }

        // Override the ToString method to display an complex number in the suitable format:
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }

    class ComplexQuadraticEquation
    {
        static void Main()
        {
            // Enter input data
            // Enter 'a' constant
            Console.Write("Enter the real of a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary of a: ");
            double a2 = double.Parse(Console.ReadLine());
            Complex a = new Complex(a1, a2);
            Console.WriteLine("The 1st complex number as 'a' constant is:  {0}\n", a);

            // Enter 'b' constant
            Console.Write("Enter the real of b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary of b: ");
            double b2 = double.Parse(Console.ReadLine());
            Complex b = new Complex(b1, b2);
            Console.WriteLine("The 2nd complex number as 'b' constant is:  {0}\n", b);

            // Enter 'c' constant
            Console.Write("Enter the real of c: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary of c: ");
            double c2 = double.Parse(Console.ReadLine());
            Complex c = new Complex(c1, c2);
            Console.WriteLine("The 3rd complex number as 'c' constant is:  {0}", c);

            // Save B = -b / 2 to computing the Delta formula
            Complex B = new Complex(-b1 / 2, -b2 / 2);

            // Computing the Delta formula
            Complex Delta = B * B - a * c;

            // Taking the Square root of the Delta formula
            Complex Omega = Complex.Sqrt(Delta);

            // Solving both of the formula
            Complex z1 = (B + Omega) / a;
            Complex z2 = (B - Omega) / a;

            // The problem and solution below:
            Console.WriteLine("\n");
            Console.WriteLine("The quadratic equation need to solve: ({0})z*z + ({1})z + ({2}) = 0", a, b, c);
            Console.WriteLine("\n");
            Console.WriteLine("The quadratic formulas of this equation are:\nz1 = " + z1 + "\n" + "z2 = " + z2 + "\n");
        }
    }
}
