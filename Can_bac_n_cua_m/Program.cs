using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Can_bac_n_cua_m
{
    class Program
    {
        public static double luythua(double x, int a, int b)
        {
            return Math.Pow(x, a) - b;
        }

        static void Main()
        {
            double c, z, epsilon, a0, b0;
            Console.WriteLine("Chuong trinh tinh can bac n cua m (m > 0)");
            Console.Write("\nNhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nNhap m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nNhap epsilon: ");
            epsilon = double.Parse(Console.ReadLine());

            a0 = 0; b0 = m;
            c = (1.0 * m) / 2;
            z = luythua(c, n, m);
            while (Math.Abs(a0 - b0) >= epsilon)
            {
                if (z * luythua(a0, n, m) < 0)
                {
                    b0 = c;
                    c = (a0 + b0) / 2;
                    z = luythua(c, n, m);
                }
                else
                {
                    a0 = c;
                    c = (a0 + b0) / 2;
                    z = luythua(c, n, m);
                }
            }
            Console.WriteLine("\nCan bac {0} cua {1} la: {2}", n, m, c);
        }
    }
}

