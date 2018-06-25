using System;

namespace DemTu_ver2
{
    class Program
    {
        static void Main()
        {
            string s;
            int i = 0, count = 1;
            Console.Write("Enter a string: ");
            s = Console.ReadLine();

            while (i <= s.Length - 1)
            {
                if (s[i] == ' ' || s[i] == '\n' || s[i] == '\t')
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("The string you have entered has {0} word(s)", count);
        }
    }
}