using System;
using System.Collections.Generic;

namespace MorseCodeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining and declaring
            string testStr = "In the nothingness, my life drifts away. It's empty, yet it's filled with nothing.\n" +
            "Life is painful, yet full of nothing. Years of nothing but pain, and I have nothing to show for it.\n" +
            "Is this all in vain? All this work, is it but for naught? All these questions, will for ever be lost\n" +
            "in the static void Main().";
            string testStrUpper = testStr.ToUpper();
            int testLen = testStr.Length;

            Dictionary<string, string> morseDict = new Dictionary<string, string>()  // Creating a dictionary which will contain a key and a value which will
                                                                                     // be used as a container for the letters and the corresponding morse code.
            {
                // Punctuation
                {" ", "  "}, {".", "· — · — · —"}, {",", "- - · · - -"}, {":", "- - - · · ·"}, {";", "- · - · - ·"},
                {"'", "· - - - - ·"}, {"\"", "· - · · - ·"}, {"-", "- · · · · -"}, {"_", "· · _ _ · _"},
                {"/", "- · · - ·"}, {"\\", "- · · - ·"}, {"?", "· · - - · ·"}, //{"!", "- · - · - -"},//
                {"(", "- · - - ·"}, {"[", "- · - - ·"}, {")", "- · - - · -"}, {"]", "- · - - · -"},
                {"+", "· - · - ·"}, {"=", "- · · · -"}, {"*", "- · · -"}, {"×", "- · · -"}, { "@", "· - - · - ·"},
                // Numbers
                {"0", "— — — — —"}, {"1", "· — — — —"}, {"2", "· · — — —"}, {"3", "· · · — —"}, {"4", "· · · · —"},
                {"5", "· · · · ·"}, {"6", "— · · · ·"}, {"7", "— — · · ·"}, {"8", "— — — · ·"}, {"9", "— — — — ·"},
                // Standard alphabet
                {"A" ,"· —"}, {"B", "— · · ·"}, {"C", "— · — ·"}, {"D", "— · ·"}, {"E", "·"}, {"F", "· · — ·"},
                {"G", "— — ·"}, {"H", "· · · ·"}, {"I", "· ·"}, {"J", "· — — —"}, {"K", "— · —"}, {"L", "· — · ·"},
                {"N", "— ·"}, {"M", "— —"}, {"O", "— — —"}, {"P", "· — — ·"}, {"Q", "— — · —"}, {"R", "· — ·"},
                {"S", "· · ·"}, {"T", "—"}, {"U", "· · —"}, {"V", "· · · —"}, {"W", "· — —"}, {"X", "— · · —"},
                {"Y", "— · — —"}, {"Z", "— — · ·"},
                // Danish letters
                {"Æ", "· — · —" }, {"Ø", "— — — ·"}, {"Å", "· — — · —"}
            };

            var convertList = new List<KeyValuePair<string, string>>(morseDict);

            Console.WriteLine("String output:\n\n" + testStr);
            Console.WriteLine("\nDictionary Key output:\n");
            {
                for (int cnt = 0; cnt < testLen; cnt++)
                {
                    string mkShrt = testStrUpper[cnt].ToString();
                    foreach (KeyValuePair<string, string> elmnt in morseDict)
                    {
                        if (elmnt.Key == mkShrt)
                        {
                            Console.Write(" {0} ", elmnt.Key);
                        }
                        else { continue; }
                    }
                }
                Console.WriteLine("\n\nDictionary Value output:\n");
                {
                    for (int cnt = 0; cnt < testLen; cnt++)
                    {
                        string mkShrt = testStrUpper[cnt].ToString();
                        foreach (KeyValuePair<string, string> elmnt in morseDict)
                        {
                            if (elmnt.Key == mkShrt)
                            {
                                Console.Write(" {0} ", elmnt.Value);
                            }
                            else { continue; }
                        }
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}