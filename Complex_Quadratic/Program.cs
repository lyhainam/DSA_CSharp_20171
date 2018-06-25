using System;
using System.Numerics;

namespace Complex_Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nNhap phan thuc so phuc a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap phan ao so phuc a: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap phan thuc so phuc b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap phan ao so phuc b: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap phan thuc so phuc c: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap phan ao so phuc c: ");
            double c2 = double.Parse(Console.ReadLine());
            Complex a = new Complex(a1, a2);
            Complex b = new Complex(b1, b2);
            Complex c = new Complex(c1, c2);
            Console.WriteLine("\nPhuong trinh bac hai co dang: ({0} + {1})z^2 + ({2} + {3}i)z + ({4} + {5}i) = 0", a1, a2, b1, b2, c1, c2);
            Complex Delta = b * b - 4 * a * c;
            if (Delta == 0)
            {
                Console.WriteLine("\nPhuong trinh co nghiem kep la: z = {0} + {1}i", (-b / a).Real, (-b / a).Imaginary);
            }
            else
            {
                Complex Omega = Complex.Sqrt(Delta);
                Complex z1 = (-b + Omega) / 2 / a;
                Complex z2 = (-b - Omega) / 2 / a;
                Console.WriteLine("\nPhuong trinh co hai nghiem phan biet la:\nz1 = {0} + {1}i va\nz2 = {2} + {3}i", z1.Real, z1.Imaginary, z2.Real, z2.Imaginary);
            }
        }
    }
}
