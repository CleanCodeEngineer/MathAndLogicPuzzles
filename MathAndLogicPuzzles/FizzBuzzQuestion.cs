using System;

namespace MathAndLogicPuzzles
{
    public class FizzBuzzQuestion
    {
        public static void FizzBuzz(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                // we use the mod operator
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
