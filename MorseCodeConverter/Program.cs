using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;


namespace MorseCodeConverter
{
    internal class Program
    {
        static void QuitProg()
        {
            Console.Clear();
            Console.WriteLine("Good-bye! Farewell! See you later, alligator! " +
                "In a while, crocodile!\n'till we meet again! " +
                "Catch you on the flipside!");
            Environment.Exit(0);
        }
        static void TextToMorse()
        {
            Console.WriteLine("This is a text to morse converter.\nPlease enter the text you want to be converted and press ENTER.\n");
            Console.Write("> ");
            // Defining and declaring
            string userTxtIn = Console.ReadLine();
            string userTxtUpper = userTxtIn.ToUpper();
            int userTxtLen = userTxtIn.Length;
            bool menuTxtOnce = false;

            Dictionary<string, string> morseDict = new Dictionary<string, string>()  // Creating a dictionary which will contain a key and a value which will
                                                                                             // be used as a container for the letters and the corresponding morse code.
                    {
                        // Punctuation
                        { " ", "  " }, { ".", "· — · — · —" }, { ",", "- - · · - -" }, { ":", "- - - · · ·" }, { ";", "- · - · - ·" },
                        { "'", "· - - - - ·" }, { "\"", "· - · · - ·" }, { "-", "- · · · · -" }, { "_", "· · _ _ · _" },
                        { "/", "- · · - ·" }, { "\\", "- · · - ·" }, { "?", "· · - - · ·" }, //{"!", "- · - · - -"},//
                        { "(", "- · - - ·" }, { "[", "- · - - ·" }, { ")", "- · - - · -" }, { "]", "- · - - · -" },
                        { "+", "· - · - ·" }, { "=", "- · · · -" }, { "*", "- · · -" }, { "×", "- · · -" }, { "@", "· - - · - ·" },
                        // Numbers
                        { "0", "— — — — —" }, { "1", "· — — — —" }, { "2", "· · — — —" }, { "3", "· · · — —" }, { "4", "· · · · —" },
                        { "5", "· · · · ·" }, { "6", "— · · · ·" }, { "7", "— — · · ·" }, { "8", "— — — · ·" }, { "9", "— — — — ·" },
                        // Standard alphabet
                        { "A", "· —" }, { "B", "— · · ·" }, { "C", "— · — ·" }, { "D", "— · ·" }, { "E", "·" }, { "F", "· · — ·" },
                        { "G", "— — ·" }, { "H", "· · · ·" }, { "I", "· ·" }, { "J", "· — — —" }, { "K", "— · —" }, { "L", "· — · ·" },
                        { "M", "— —" }, { "N", "— ·" }, { "O", "— — —" }, { "P", "· — — ·" }, { "Q", "— — · —" }, { "R", "· — ·" },
                        { "S", "· · ·" }, { "T", "—" }, { "U", "· · —" }, { "V", "· · · —" }, { "W", "· — —" }, { "X", "— · · —" },
                        { "Y", "— · — —" }, { "Z", "— — · ·" },
                        // Danish letters
                        { "Æ", "· — · —" }, { "Ø", "— — — ·" }, { "Å", "· — — · —" }
                    };

            var convertList = new List<KeyValuePair<string, string>>(morseDict);

            Console.WriteLine("String output:\n\n" + userTxtIn);
            Console.WriteLine("\nDictionary Key output:\n");
            {
                for (int cnt = 0; cnt < userTxtLen; cnt++)
                {
                    string mkShrt = userTxtUpper[cnt].ToString();
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
                    for (int cnt = 0; cnt < userTxtLen; cnt++)
                    {
                        string mkShrt = userTxtUpper[cnt].ToString();
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

        static void MorseToText()
        {
            Console.WriteLine("Sorry, this feature has yet to be implemented");
        }
        static void MorseShowcase()
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
                        { " ", "  " }, { ".", "· — · — · —" }, { ",", "- - · · - -" }, { ":", "- - - · · ·" }, { ";", "- · - · - ·" },
                        { "'", "· - - - - ·" }, { "\"", "· - · · - ·" }, { "-", "- · · · · -" }, { "_", "· · _ _ · _" },
                        { "/", "- · · - ·" }, { "\\", "- · · - ·" }, { "?", "· · - - · ·" }, //{"!", "- · - · - -"},//
                        { "(", "- · - - ·" }, { "[", "- · - - ·" }, { ")", "- · - - · -" }, { "]", "- · - - · -" },
                        { "+", "· - · - ·" }, { "=", "- · · · -" }, { "*", "- · · -" }, { "×", "- · · -" }, { "@", "· - - · - ·" },
                        // Numbers
                        { "0", "— — — — —" }, { "1", "· — — — —" }, { "2", "· · — — —" }, { "3", "· · · — —" }, { "4", "· · · · —" },
                        { "5", "· · · · ·" }, { "6", "— · · · ·" }, { "7", "— — · · ·" }, { "8", "— — — · ·" }, { "9", "— — — — ·" },
                        // Standard alphabet
                        { "A", "· —" }, { "B", "— · · ·" }, { "C", "— · — ·" }, { "D", "— · ·" }, { "E", "·" }, { "F", "· · — ·" },
                        { "G", "— — ·" }, { "H", "· · · ·" }, { "I", "· ·" }, { "J", "· — — —" }, { "K", "— · —" }, { "L", "· — · ·" },
                        { "M", "— —"}, { "N", "— ·" }, { "O", "— — —" }, { "P", "· — — ·" }, { "Q", "— — · —" }, { "R", "· — ·" },
                        { "S", "· · ·" }, { "T", "—" }, { "U", "· · —" }, { "V", "· · · —" }, { "W", "· — —" }, { "X", "— · · —" },
                        { "Y", "— · — —" }, { "Z", "— — · ·" },
                        // Danish letters
                        { "Æ", "· — · —" }, { "Ø", "— — — ·" }, { "Å", "· — — · —" }
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
        static int MorseFromKey()
        {
            Console.WriteLine("Here you can type any key on your keyboard to have the corresponding morse code shown.\n" +
                "Press ESCAPE when you want to quit the application, or ENTER to return to the main menu." +
                "\n\nPlease note that not every key works, such as punctuation and internation letters. Sorry.\nI will look into it later.\n\n");
            while (true)
            {
                var keyPress = Console.ReadKey(false).Key;
                switch (keyPress)
                {
                    case ConsoleKey.Enter:
                        return 0;
                    case ConsoleKey.Escape: // Exits the application.
                        QuitProg();
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine(" is · —");
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine(" is — · · ·");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine(" is — · — ·");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine(" is — · ·");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine(" is ·");
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine(" is · · — ·");
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine(" is — — ·");
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine(" is · · · ·");
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine(" is · ·");
                        break;
                    case ConsoleKey.J:
                        Console.WriteLine(" is · — — —");
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine(" is — · —");
                        break;
                    case ConsoleKey.L:
                        Console.WriteLine(" is · — · ·");
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine(" is — —");
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine(" is — ·");
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine(" is — — —");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine(" is · — — ·");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine(" is — — · —");
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine(" is · — ·");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine(" is · · ·");
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine(" is —");
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine(" is · · —");
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine(" is · · · —");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine(" is · — —");
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine(" is — · · —");
                        break;
                    case ConsoleKey.Y:
                        Console.WriteLine(" is — · — —");
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine(" is — — · ·");
                        break;
                    default: break;
                }
            }
        }

        static void AboutMe()
        {
            Console.WriteLine("I'm a loser.");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Morse Code Converter!\n");

            // Dialogue Box - Constructing so it scales properly.
            int sizeLen = 66;
            var horiLine = String.Concat(Enumerable.Repeat("─", sizeLen + 2));
            string vertLine = "│";
            string twoSpace = "  ";
            string indicator = " ►";

            // Text for the program.
            string txt_0, txt_1, txt_2, txt_3, txt_4, txt_5, txt_6, txt_7, txt_8;
            txt_0 = "1 - Convert text into morse code";
            txt_1 = "2 - Convert morse code into text";
            txt_2 = "3 - Convert sample text into morse code";
            txt_3 = "4 - Morse code tester (key to morse code)";
            txt_4 = "5 - About me";
            txt_5 = "[EXIT]";
            txt_6 = "Use the UP and DOWN arrow on your keyboard to navigate the menu.";
            txt_7 = "Press ENTER to confirm.";
            txt_8 = "While on this menu, you can press ESCAPE to exit the application.";

            // Calculating the string lengths.
            int txt_0_Len, txt_1_Len, txt_2_Len, txt_3_Len, txt_4_Len,
                txt_5_Len, txt_6_Len, txt_7_Len, txt_8_Len;
            txt_0_Len = txt_0.Length;
            txt_1_Len = txt_1.Length;
            txt_2_Len = txt_2.Length;
            txt_3_Len = txt_3.Length;
            txt_4_Len = txt_4.Length;
            txt_5_Len = txt_5.Length;
            txt_6_Len = txt_6.Length;
            txt_7_Len = txt_7.Length;
            txt_8_Len = txt_8.Length;
            // Automatically adjusting the spacing according to the string length.
            var spaceLine_Empty = String.Concat(Enumerable.Repeat(" ", sizeLen));
            var spaceLine_0 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_0_Len));
            var spaceLine_1 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_1_Len));
            var spaceLine_2 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_2_Len));
            var spaceLine_3 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_3_Len));
            var spaceLine_4 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_4_Len));
            var spaceLine_5 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_5_Len));
            var spaceLine_6 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_6_Len));
            var spaceLine_7 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_7_Len));
            var spaceLine_8 = String.Concat(Enumerable.Repeat(" ", sizeLen - txt_8_Len));

            bool sel_0, sel_1, sel_2, sel_3, sel_4, sel_5;
            sel_0 = false; sel_1 = false; sel_2 = true; sel_3 = false;
            sel_4 = false; sel_5 = false;


            int updBox = 0;
            bool enterPressed, backspcPressed;
            enterPressed = false;
            backspcPressed = false;
            do
            {
                // Setting up the keyboard controls, assigning the actions.
                while (true)
                {
                    var keyPress = Console.ReadKey(false).Key;
                    switch (keyPress)
                    {
                        case ConsoleKey.Escape: // Exits the application.
                            QuitProg();
                            return;
                        case ConsoleKey.UpArrow: // Moves the arrow indicator up visually by subtracting from the value.
                            updBox--;
                            enterPressed = false;
                            break;
                        case ConsoleKey.DownArrow: // Moves the arrow indicator down visually by adding to the value.
                            updBox++;
                            enterPressed = false;
                            break;
                        case ConsoleKey.Enter:  // The action will result in next.
                            enterPressed = true;
                            break;
                        default: break;
                    }
                    if (updBox > 5)  // When the update box value goes above 6, it will then turn the integer into 0.
                    {
                        updBox = 0;
                    }
                    else if (updBox < 0)  // Vice versa, if the value goes below 0, it will turn the integer into 5.
                    {
                        updBox = 5;
                    }
                    switch (updBox)  // A mess of switches that declare where the arrow indicator will and will not be shown.
                    {
                        case 0:
                            sel_0 = true; sel_1 = false; sel_2 = false; sel_3 = false; sel_4 = false;
                            sel_5 = false;
                            break;
                        case 1:
                            sel_0 = false; sel_1 = true; sel_2 = false; sel_3 = false; sel_4 = false;
                            sel_5 = false;
                            break;
                        case 2:
                            sel_0 = false; sel_1 = false; sel_2 = true; sel_3 = false; sel_4 = false;
                            sel_5 = false;
                            break;
                        case 3:
                            sel_0 = false; sel_1 = false; sel_2 = false; sel_3 = true; sel_4 = false;
                            sel_5 = false;
                            break;
                        case 4:
                            sel_0 = false; sel_1 = false; sel_2 = false; sel_3 = false; sel_4 = true;
                            sel_5 = false;
                            break;
                        case 5:
                            sel_0 = false; sel_1 = false; sel_2 = false; sel_3 = false; sel_4 = false;
                            sel_5 = true;
                            break;

                    }
                    Console.Clear();  // This clears the screen, so it works as a refreshing mechanism upon the user's input.
                    //Console.WriteLine(updBox);

                    // This is the structure of how the dialogue box is built.
                    Console.WriteLine("┌" + horiLine + "┐");

                    if (sel_0 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_0 + spaceLine_0 + vertLine);
                        if (enterPressed == true)  // Open text to morse code converter
                        {
                            Console.ResetColor();
                            Console.Clear();
                            TextToMorse();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_0 + spaceLine_0 + vertLine);

                    }
                    if (sel_1 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_1 + spaceLine_1 + vertLine);
                        if (enterPressed == true)  // Open morse to text converter
                        {
                            Console.ResetColor();
                            Console.Clear();
                            MorseToText();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_1 + spaceLine_1 + vertLine);
                    }
                    if (sel_2 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_2 + spaceLine_2 + vertLine);
                        if (enterPressed == true)  //  Open sample string.
                        {
                            Console.ResetColor();
                            Console.Clear();
                            MorseShowcase();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_2 + spaceLine_2 + vertLine);
                    }
                    if (sel_3 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_3 + spaceLine_3 + vertLine, Console.ForegroundColor);
                        if (enterPressed == true)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            MorseFromKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_3 + spaceLine_3 + vertLine);
                    }
                    if (sel_4 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_4 + spaceLine_4 + vertLine);
                        if (enterPressed == true)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            AboutMe();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_4 + spaceLine_4 + vertLine);
                    }
                    if (sel_5 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(vertLine + indicator + txt_5 + spaceLine_5 + vertLine);
                        if (enterPressed == true)
                        {
                            Console.ResetColor();
                            Console.Clear();
                            QuitProg();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(vertLine + twoSpace + txt_5 + spaceLine_5 + vertLine);
                    }
                    //Console.WriteLine(b_isSelected = sel_7);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(vertLine + twoSpace + spaceLine_Empty + vertLine);
                    Console.WriteLine(vertLine + twoSpace + txt_6 + spaceLine_6 + vertLine);
                    Console.WriteLine(vertLine + twoSpace + txt_7 + spaceLine_7 + vertLine);
                    Console.WriteLine(vertLine + twoSpace + txt_8 + spaceLine_8 + vertLine);
                    Console.WriteLine("└" + horiLine + "┘");
                }

            } while (true);
        }
    }
}