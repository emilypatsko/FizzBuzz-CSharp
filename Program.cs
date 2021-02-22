﻿using System;

namespace FizzBuzz_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            for (var i = 0; i < length; i++) {
                int num = i + 1;
                if ((num % 3 == 0) && (num % 5 == 0)) {
                    Console.WriteLine("FizzBuzz");
                } else if (num % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (num % 5 == 0 ) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(num);
                }                
            }
        }
    }
}
