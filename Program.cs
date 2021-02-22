using System;
using System.Collections.Generic;

namespace FizzBuzz_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100;
            List<string> thingsToPrint = new List<string> ();
            
            for (var i = 0; i < length; i++) {
                int num = i + 1;    
                if ((num % 3 != 0) && (num % 5 != 0)) {
                    thingsToPrint.Add(num.ToString());
                } else {       
                    thingsToPrint.Add("");  

                    if (num % 3 == 0) {
                        thingsToPrint[i] = "Fizz";
                    }
                    if (num % 5 == 0) {
                        thingsToPrint[i] += "Buzz";
                    }
                }         
            }

            thingsToPrint.ForEach(Console.WriteLine);
        }
    }
}
