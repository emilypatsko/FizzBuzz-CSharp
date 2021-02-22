using System;
using System.Collections.Generic;

namespace FizzBuzz_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 255;
            List<string> thingsToPrint = new List<string> ();
            
            for (var i = 0; i < length; i++) {
                int num = i + 1;    
                if ((num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0) && (num % 11 != 0) && (num % 13 != 0) && (num % 17 != 0)) {
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
                    if (num % 17 == 0) {
                        if (thingsToPrint[i].Length > 4) {
                            List<string> thingToReverse = new List<string>();
                            for (var j = 0; j < thingsToPrint[i].Length/4; j++) {
                                thingToReverse.Add(thingsToPrint[i].Substring(j * 4, 4));
                            }
                            thingToReverse.Reverse();
                            thingsToPrint[i] = string.Concat(thingToReverse.ToArray());
                        }                        
                    }
                }         
            }

            thingsToPrint.ForEach(Console.WriteLine);
        }
    }
}
