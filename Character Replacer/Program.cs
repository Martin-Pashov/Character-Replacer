using System;
using System.Text;

namespace Character_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder stringB = new StringBuilder();
            char s = input[0];

            stringB.Append(s);

            for (int i = 1; i < input.Length; i++)
            {
                if (s != input[i])
                {
                    s = input[i];
                    stringB.Append(s);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The converted word is this: {stringB}");
        }
    }
}
