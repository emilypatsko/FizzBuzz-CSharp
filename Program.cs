using System;

namespace FizzBuzz_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++) {
                int num = i + 1;
                if (num % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else {
                    Console.WriteLine(num);
                }
                
            }
        }
    }
}
