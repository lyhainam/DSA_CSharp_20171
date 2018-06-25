using System;

namespace SoPI
{
    class Program
    {
        static void Main()
        {
            double epsilon = 0, PI, PI_1 = 0.0, PI_2 = 1.0;
            int i = 1, sign = -1;
            Console.Write("Nhap sai so epsilon: ");
            epsilon = double.Parse(Console.ReadLine());
            
            while (Math.Abs(PI_1 - PI_2) > epsilon)
            {
                PI_1 = PI_2;
                PI_2 += 1 / (double)(sign * (2 * i + 1));
                sign = -sign;
                i++;
            }
            PI = 4 * PI_2;
            Console.WriteLine("\nGia tri xap xi cua PI la: {0}", PI);
            Console.ReadLine();
        }
    }
}