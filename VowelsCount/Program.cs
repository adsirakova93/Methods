using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }
        private static int VowelsCount(string input)
        {
            int vowelsCCount = 0;
            //a o e u i y
            string inputToLower = input.ToLower();
            for (int i = 0; i < inputToLower.Length; i++)
            {
                if (inputToLower[i] == 'a' ||
                    inputToLower[i] == 'e' ||
                    inputToLower[i] == 'u' ||
                    inputToLower[i] == 'o' ||
                    inputToLower[i] == 'i' ||
                    inputToLower[i] == 'y')
                {
                    vowelsCCount++;
                }

            }
            return vowelsCCount;

        }
    }
}
