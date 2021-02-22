using System;
using System.Collections.Generic;

namespace FizzBuzz_C_
{
    class Program
    {

        static string FizzRule(int num, string thingToPrint)
        {
            if (num % 3 == 0) {
                    thingToPrint+= "Fizz";
            }  
            return thingToPrint;
        }

        static string BuzzRule(int num, string thingToPrint)
        {
            if (num % 5 == 0) {
                    thingToPrint += "Buzz";
            }
            return thingToPrint;
        }
        
        static string BangRule(int num, string thingToPrint)
        {
            if (num % 7 == 0) {
                    thingToPrint += "Bang";
            }
            return thingToPrint;
        }

        static string BongRule(int num, string thingToPrint)
        {
            if (num % 11 == 0) {
                    thingToPrint = "Bong";
            }
            return thingToPrint;
        }

        static string FezzRule(int num, string thingToPrint)
        {
            if (num % 13 == 0) {
                int bIndex = thingToPrint.IndexOf("B");
                if (bIndex > -1) {
                    thingToPrint = thingToPrint.Substring(0, bIndex) + "Fezz" + thingToPrint.Substring(bIndex);
                } else {
                    thingToPrint += "Fezz";
                }                      
            }
            return thingToPrint;
        }

        static string ReverseRule(int num, string thingToPrint)
        {
            if (num % 17 == 0) {
                if (thingToPrint.Length > 4) {
                    List<string> thingToReverse = new List<string>();
                    for (var j = 0; j < thingToPrint.Length/4; j++) {
                        thingToReverse.Add(thingToPrint.Substring(j * 4, 4));
                    }
                    thingToReverse.Reverse();
                    thingToPrint = string.Concat(thingToReverse.ToArray());
                }                        
            }
            return thingToPrint;
        }
        static void Main(string[] args)
        {

            // Default all rules to true and maximum printing number to 100
            Dictionary<string, bool> rules = new Dictionary<string, bool> 
                {
                    {"Fizz", true},
                    {"Buzz", true},
                    {"Bang", true},
                    {"Bong", true},
                    {"Fezz", true},
                    {"Reverse", true}
                };
            int length = 100;

            if (args.Length > 0) {
                bool isInteger = Int32.TryParse(args[0], out length);
                Console.WriteLine(length);
                if (!isInteger) {
                    length = 100;
                    // System.Environment.Exit(1); // think I should exit in a different way
                }     

                foreach(var rule in rules) {
                    if (Array.IndexOf(args, rule.Key) > -1) {
                        rules[rule.Key] = true;
                    } else {
                        rules[rule.Key] = false;
                    }
                }
                
                // Debugging
                // foreach(var rule in rules) {
                //     Console.WriteLine($"{rule.Key}:{(rule.Value ? "ON" : "OFF")}");
                // }
            }

            List<string> thingsToPrint = new List<string> ();
            
            for (var i = 0; i < length; i++) {
                int num = i + 1;   
                thingsToPrint.Add("");  

                if (rules["Fizz"]) {thingsToPrint[i] = FizzRule(num, thingsToPrint[i]);}
                if (rules["Buzz"]) {thingsToPrint[i] = BuzzRule(num, thingsToPrint[i]);}
                if (rules["Bang"]) {thingsToPrint[i] = BangRule(num, thingsToPrint[i]);}
                if (rules["Bong"]) {thingsToPrint[i] = BongRule(num, thingsToPrint[i]);}
                if (rules["Fezz"]) {thingsToPrint[i] = FezzRule(num, thingsToPrint[i]);}
                if (rules["Reverse"]) {thingsToPrint[i] = ReverseRule(num, thingsToPrint[i]);}
                if (thingsToPrint[i] == "") {
                    thingsToPrint[i] = num.ToString();
                }
            }

            thingsToPrint.ForEach(Console.WriteLine);
        }
    }
}
