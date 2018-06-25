using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemTu
{
    class Program
    {
        static void Main()
        {
            string[] s;
            char[] c = { '\t', ' ', '`', '~', '!', '@', '#',
                           '$', '%', '^', '&', '*', '(', ')',
                           '-', '_', '=', '+', '[', ']', '{',
                           '}', ';', '\'', '\\', ':', '\"',
                           '|', ',', '.', '/', '<', '>', '?' };
            Console.Write("Enter a string: ");
            s = Console.ReadLine().Split(c, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("The string you have entered has {0} word(s)", s.Length);
        }
    }
}
