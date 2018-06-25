using System;
using System.Collections.Generic;

namespace Bin
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("The following program converts a decimal number to the binary string");
            Console.Write("\nEnter n: ");
            double n = double.Parse(Console.ReadLine());
            int m = (int)n;
            double tp = n - m;
            do
            {
                stack.Push(m % 2);
                m = m / 2;
            } while (m > 0);
            
            while(tp != 0)
            {
                queue.Enqueue((int)(tp * 2));
                tp = (tp * 2) - (int)(tp * 2);
            }
            Console.Write("\nThe Binary string of {0} is: ", n);
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.Write(".");
            while (queue.Count != 0)
            {
                Console.Write(queue.Dequeue());
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
