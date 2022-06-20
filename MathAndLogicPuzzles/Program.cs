using System;

namespace MathAndLogicPuzzles
{
    // FizzBuzz: Output numbers from 1 to x. If the number is divisible
    // by 3, replace it with "Fizz". If it is divisible by 5, replace
    // it with "Buzz". If it is divisible by 3 and 5 replace it with
    // "FizzBuzz".
    // eg:
    // 1
    // 2
    // Fizz
    // 4
    // Buzz
    // 6
    // -
    // 14
    // FizzBuzz
    // 16
    // -
    class MainClass
    {
        public static void Main(string[] args)
        {
            FizzBuzzQuestion.FizzBuzz(16);
            Console.ReadLine();
        }


    }
}
