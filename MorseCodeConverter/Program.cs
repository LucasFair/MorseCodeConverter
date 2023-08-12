using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace MorseCodeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // — ·

            string convertIn;
            string convertOut;

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
            //string testStr = "Pain";
            string testStr = "In the nothingness, my life drifts away. It's empty, yet it's filled with nothing.\n" +
                "Life is painful, yet full of nothing. Years of nothing but pain, and I have nothing to show for it.\n" +
                "Is this all in vain? All this work, is it but for nought? All these questions, will for ever be lost\n" +
                "in the static void Main().";
            string testStrUpper = testStr.ToUpper();
            int testLen = testStr.Length;

            Console.WriteLine("String output:\n\n" + testStr);

            Console.WriteLine("\nDictionary Key output:\n");
            {
                //for (int cnt = 0; cnt < convertList.Count; cnt++)
                for (int cnt = 0; cnt < testLen; cnt++)
                {
                    string mkShrt = testStrUpper[cnt].ToString();
                    foreach (KeyValuePair<string, string> elmnt in morseDict)
                    {
                        if (elmnt.Key == mkShrt)
                        {
                            Console.Write(" {0} ", elmnt.Key);

                            /*
                             Console.WriteLine("\nYour input was:");
                             Console.Write("{0}", elmnt.Key);
                             Console.WriteLine("\nThe output is:");
                             Console.Write("{0}", elmnt.Value);
                             */
                            //Console.Write(cnt);
                            continue;
                        }
                        else {; }
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
                                continue;
                            }
                            else {; }
                        }
                    }

                }
            }
            Console.WriteLine("");
            Console.WriteLine("");







            /*
            string convertToStr = convertList.ToString();

            String txtIn = Console.ReadLine();
            string convertIn;
            string convertOut;
            */
            /*
            foreach (KeyValuePair<string, string> elmnt in morseDict)
            {
                Console.WriteLine("{0} is {1}", elmnt.Key, elmnt.Value);
            } */
        }
    }
}