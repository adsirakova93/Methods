using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintCharacterinRange(start, end);
        }

        private static void PrintCharacterinRange(char start, char end)
        {
            //ako kraq e po-golqm ot nachaloto
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
