using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class2
    {
        static void Main()
        {
            WinSize(81, 41);

            int n = 1;
            Page(n);

            while (true)
            {
                if(Console.KeyAvailable == true)
                {
                    char numCh = Getch();

                    if (numCh == 'a')
                    {
                        --n;
                        if (n == 0) n = 4;
                        CLS(); Page(n);
                    }
                    else if (numCh == 'd')
                    {
                        ++n;
                        if (n == 5) n = 1;
                        CLS(); Page(n);
                    }
                    else if (numCh == 'k') break;
                }
            }

            Locate(0, 35);
        }

        static void Page(int n)
        {
            if(n == 1)       PageOne();
            else if(n == 2)  PageTwo();
            else if (n == 3) PageThree();
            else if (n == 4) PageFour();
        }

        static void PageOne()
        {
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");
            for(int i = 0; i <= 31; ++i)
            {
                if(i >= 7 && i <= 10)
                {
                    Print($"  {i}");
                    Print("\t\t"); PrintBinary(i);
                    Print("\t\t"); PrintHex(i);
                    Print("\n");
                }
                else
                {
                    Print($"  {i}");
                    Print("\t\t"); PrintBinary(i);
                    Print("\t\t"); PrintHex(i);
                    Print("\t\t"); PrintAsciiLetter(i);
                    Print("\n");
                }
            }
        }

        static void PageTwo()
        {
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");
            for (int i = 32; i <= 63; ++i)
            {
                Print($"  {i}");
                Print("\t\t"); PrintBinary(i);
                Print("\t\t"); PrintHex(i);
                Print("\t\t"); PrintAsciiLetter(i);
                Print("\n");
            }
        }

        static void PageThree()
        {
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");
            for (int i = 64; i <= 95; ++i)
            {
                Print($"  {i}");
                Print("\t\t"); PrintBinary(i);
                Print("\t\t"); PrintHex(i);
                Print("\t\t"); PrintAsciiLetter(i);
                Print("\n");
            }
        }

        static void PageFour()
        {
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");
            for (int i = 96; i <= 127; ++i)
            {
                Print($"  {i}");
                Print("\t\t"); PrintBinary(i);
                Print("\t\t"); PrintHex(i);
                Print("\t\t"); PrintAsciiLetter(i);
                Print("\n");
            }
        }

        static void PrintBinary(int n)
        {
            string str = "";
            int q = n, a;

            while(q != 0)
            {
                a = q % 2; q = q / 2;
                str = a + str;
            }

            if (str.Length < 8)
                for (int count = 1, numOfZero = 8 - str.Length; count <= numOfZero; str = 0 + str, ++count) ;

            Print($"{str}");
        }

        static void PrintHex(int n)
        {
            string str = "";
            int q = n, a;

            while (q != 0)
            {
                a = q % 16; q = q / 16;

                if (a >= 10 && a <= 15) str = HexChar(a) + str;
                else str = a + str;
            }

            if (str.Length == 1) str = 0 + str;
            if(n == 0) str = "00";

            Print($"{str}");
        }

        static string HexChar(int a)
        {
            string ch = "";

            if (a == 10)      ch = "A";
            else if(a == 11)  ch = "B";
            else if (a == 12) ch = "C";
            else if (a == 13) ch = "D";
            else if (a == 14) ch = "E";
            else if (a == 15) ch = "F";

            return ch;
        }

        static void PrintAsciiLetter(int n)
        {
            char ch = (char)n;
            Print($"{ch}");
        }

        static char Getch()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            return key.KeyChar;
        }

        static void WinSize(int x, int y)
        {
            Console.SetWindowSize(x, y);
        }

        static void Locate(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Print(string text)
        {
            Console.Write(text);
        }

        static void CLS()
        {
            Console.Clear();
        }
    }
}