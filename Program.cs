using System;
using System.Collections.Generic;

namespace FizzBuzz_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 196;
            List<string> thingsToPrint = new List<string> ();
            
            for (var i = 0; i < length; i++) {
                int num = i + 1;    
                if ((num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0) && (num % 11 != 0) && (num % 13 != 0)) {
                    thingsToPrint.Add(num.ToString());
                } else {       
                    thingsToPrint.Add("");  

                    if (num % 3 == 0) {
                        thingsToPrint[i] += "Fizz";
                    }                    
                    if (num % 5 == 0) {
                        thingsToPrint[i] += "Buzz";
                    }
                    if (num % 7 == 0) {
                        thingsToPrint[i] += "Bang";
                    }
                    if (num % 11 == 0) {
                        thingsToPrint[i] = "Bong";
                    }
                    if (num % 13 == 0) {
                        int bIndex = thingsToPrint[i].IndexOf("B");
                        if (bIndex > -1) {
                            thingsToPrint[i] = thingsToPrint[i].Substring(0, bIndex) + "Fezz" + thingsToPrint[i].Substring(bIndex);
                        } else {
                            thingsToPrint[i] += "Fezz";
                        }                      
                    }
                }         
            }

            thingsToPrint.ForEach(Console.WriteLine);
        }
    }
}
