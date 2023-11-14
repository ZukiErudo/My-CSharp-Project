using System;

namespace c__Project_2
{
    internal class Class1
    {
        static void Main()
        {
            Print("Enter a string: ");
            string str = Console.ReadLine();
            bool checkIfPeriodic = false;

            if (PrimeCheck(str.Length) == true) AltCheck(str);
            else
            {
                for(int totalSubStrParts = 2; totalSubStrParts <= str.Length - 1; ++totalSubStrParts)
                {
                    if(str.Length % totalSubStrParts == 0)
                    {
                        checkIfPeriodic = Check(str, str.Length / totalSubStrParts, totalSubStrParts);

                        if(checkIfPeriodic == true)
                        {
                            Print("Is a periodical string\n"); break;
                        }
                    }
                }
            }

            if(checkIfPeriodic == false && PrimeCheck(str.Length) == false) Print("Not a periodical string\n");
        }

        static bool Check(string str, int subLen, int totalSubStrParts) 
        {
            bool strCheck = false;
            int count = 1, index = 0;

            string firstSubStr = str.Substring(0, subLen);
            string sequelSubStr = str.Substring(subLen * (++index), subLen);

            Print($"\n");

            for (int i = 0; i < subLen; Print($"  {i}"), ++i) ;

            Print($"\n");

            for(int i = 0; i < subLen; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print($"  {firstSubStr[i]}");
            }

            Print($"\n");

            while (count < totalSubStrParts)
            {
                if (firstSubStr == sequelSubStr)
                {
                    for (int i = 0; i < subLen; ++i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Print($"  {sequelSubStr[i]}");
                    }

                    Print("\n");

                    if (count == totalSubStrParts - 1)
                    {
                        strCheck = true; break;
                    }

                    sequelSubStr = str.Substring(subLen * (++index), subLen);
                }
                else
                {
                    for (int i = 0; i < subLen; ++i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Print($"  {sequelSubStr[i]}");
                    }

                    Print("\n\n");
                    break;
                }

                ++count;
            }

            Console.ForegroundColor= ConsoleColor.White;
            return strCheck;
        }

        static void AltCheck(string str)
        {
            bool strCheck = true;

            for(int i = 0; i < str.Length - 1; ++i)
            {
                if (str[i] != str[i + 1])
                {
                    strCheck = false; break;
                }
            }

            if (strCheck == true) Print("Is a periodical string\n");
            else Print("Not a periodical string\n");
        }

        static bool PrimeCheck(int n)
        {
            bool check = false;
            int num = 2, count = 0;

            while (num <= n)
            {
                if (n % num == 0) ++count;
                ++num;
            }

            if (count == 1) check = true;
            return check;
        }

        static void Print(string text)
        {
            Console.Write(text);
        }

        static void Locate(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}