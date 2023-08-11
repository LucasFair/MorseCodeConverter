using System;
using System.Collections.Generic;

namespace MorseCodeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // — ·

            Dictionary<string, string> morseDict = new Dictionary<string, string>()
            {
                {"A" ,"· —"}, {"B", "— · · ·"}, {"C", "— · — ·"}, {"D", "— · ·"}, {"E", "·"}, {"F", "· · — ·"},
                {"G", "— — ·"}, {"H", "· · · ·"}, {"I", "· ·"}, {"J", "· — — —"}, {"K", "— · —"}, {"L", "· — · ·"},
                {"N", "— ·"}, {"M", "— —"}, {"O", "— — —"}, {"P", "· — — ·"}, {"Q", "— — · —"}, {"R", "· — ·"},
                {"S", "· · ·"}, {"T", "—"}, {"U", "· · —"}, {"V", "· · · —"}, {"W", "· — —"}, {"X", "— · · —"},
                {"Y", "— · — —"}, {"Z", "— — · ·"} 

            };


            foreach (KeyValuePair<string, string> elmnt in morseDict)
            {
                Console.WriteLine("{0} is {1}", elmnt.Key, elmnt.Value);
            }
        }
    }
}