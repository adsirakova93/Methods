using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main( )
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(number1,number2,number3));

        }
        static int SmallestNumber(int number1, int number2, int number3)
        {
            if (number1 < number2 && number1 < number3)
            {
                return number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
