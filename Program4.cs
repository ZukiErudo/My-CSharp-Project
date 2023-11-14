using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace c__Project_2
{
    internal class Class4
    {
        static void Main()
        {
            //PeriodicString();       //Bai 28: chuoi tuan hoan

            //AsciiTable();           //Bai 22: Bang ma Unicode

            //DrawTheRectangular();   //Bai 12: Di chuyen Hinh Chu Nhat va Dieu Chinh  Kich thuoc
                                      //Thay nhan WASD de di chuyen va + hoac - de phong to kich thuoc 

            //TheGame();              //Bai 10: Tro Choi :)

            Intro();                  //Menu de thay chon bai de xem
        }

        /////////////////////////////////////////////////

        static void Intro()
        {
            string ans = "y";
            while (ans == "y")
            {
                CLS();
                int num = Menu();
                CLS();
                
                if (num == 1)      TheGame();
                else if (num == 2) DrawTheRectangular();
                else if (num == 3) AsciiTable();
                else if (num == 4) PeriodicString();

                do
                {
                    Print("Ban co muon quay lai menu chinh (y/n): ");
                    ans = Console.ReadLine();
                } while (!(ans == "y" || ans == "n"));
            }

            Print("\n\n\t\tGoodbye!\n");
        }

        /////////////////////////////////////////////////

        static int Menu()
        {
            WinSize(62, 25);
            Locate(11, 22); Print("Press WASD to move and press K to choose");
           
            int col = 1, row = 1, oldcol, oldrow, chosen;
            long delay = 15000000;
            char ch;

            while (true)
            {
                for (long wait = 0; wait < delay; ++wait) ;

                oldcol = col; oldrow = row;

                AllCell();
                Words();
                ButtonLocation(col, row);
                chosen = ChosenOne(col, row);

                if (Console.KeyAvailable == true)
                {
                    ch = Getch();

                    if (ch == 'w')
                    {
                        Console.Beep(500, 50);
                        --row;
                        if (row == 0) row = 1;
                        ClearButtonLocation(oldcol, oldrow);
                    }
                    else if (ch == 's')
                    {
                        Console.Beep(500, 50);
                        ++row;
                        if (row == 3) row = 2;
                        ClearButtonLocation(oldcol, oldrow);
                    }
                    else if (ch == 'a')
                    {
                        Console.Beep(500, 50);
                        --col;
                        if (col == 0) col = 1;
                        ClearButtonLocation(oldcol, oldrow);
                    }
                    else if (ch == 'd')
                    {
                        Console.Beep(500, 50);
                        ++col;
                        if (col == 3) col = 2;
                        ClearButtonLocation(oldcol, oldrow);
                    }
                    else if (ch == 'k')
                    {
                        Console.Beep(1000, 50); break;
                    }
                }
            }

            return chosen;
        }

        /////////////////////////////////////////////////

        static void Words()
        {
            Locate(13, 4);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 10");
            Locate(12, 5);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Tro choi");
            Locate(44, 4);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 12");
            Locate(40, 5);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Di chuyen HCN");
            Locate(12, 15); Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 22");
            Locate(8, 16);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bang ma Unicode");
            Locate(44, 15); Console.ForegroundColor = ConsoleColor.Magenta;   Print("Bai 28");
            Locate(40, 16); Console.ForegroundColor = ConsoleColor.Magenta;   Print("Chuoi tuan hoan");

            Console.ForegroundColor = ConsoleColor.White;
        }

        static int ChosenOne(int col, int row)
        {
            int num = 0;
            if (col == 1 && row == 1) num = 1;
            if (col == 2 && row == 1) num = 2;
            if (col == 1 && row == 2) num = 3;
            if (col == 2 && row == 2) num = 4;
            
            return num;
        }

        //////////////////////////////////////////////////

        static void ButtonLocation(int col, int row)
        {
            if (col == 1 && row == 1) Button(0, 0);
            if (col == 2 && row == 1) Button(31, 0);
            if (col == 1 && row == 2) Button(0, 10);
            if (col == 2 && row == 2) Button(31, 10);
        }

        static void Button(int x, int y)
        {
            Locate(x, y);     Print("..............................");
            Locate(x, y + 1); Print("..............................");
            Locate(x, y + 2); Print("..............................");
            Locate(x, y + 3); Print("..............................");
            Locate(x, y + 4); Print("..............................");
            Locate(x, y + 5); Print("..............................");
            Locate(x, y + 6); Print("..............................");
            Locate(x, y + 7); Print("..............................");
            Locate(x, y + 8); Print("..............................");
            Locate(x, y + 9); Print("..............................");
        }

        //////////////////////////////////////////////////

        static void ClearButtonLocation(int col, int row)
        {
            if (col == 1 && row == 1) ClearButton(0, 0);
            if (col == 2 && row == 1) ClearButton(31, 0);
            if (col == 1 && row == 2) ClearButton(0, 10);
            if (col == 2 && row == 2) ClearButton(31, 10);
        }

        static void ClearButton(int x, int y)
        {
            Locate(x, y);     Print("                              ");
            Locate(x, y + 1); Print("                              ");
            Locate(x, y + 2); Print("                              ");
            Locate(x, y + 3); Print("                              ");
            Locate(x, y + 4); Print("                              ");
            Locate(x, y + 5); Print("                              ");
            Locate(x, y + 6); Print("                              ");
            Locate(x, y + 7); Print("                              ");
            Locate(x, y + 8); Print("                              ");
            Locate(x, y + 9); Print("                              ");
        }

        //////////////////////////////////////////////////

        static void AllCell()
        {
            Cell(0, 0); Cell(31, 0);
            Cell(0, 10); Cell(31, 10);
        }

        static void Cell(int x, int y)
        {
            Locate(x, y);     Print("******************************");
            Locate(x, y + 1); Print("*                            *");
            Locate(x, y + 2); Print("*                            *");
            Locate(x, y + 3); Print("*                            *");
            Locate(x, y + 4); Print("*                            *");
            Locate(x, y + 5); Print("*                            *");
            Locate(x, y + 6); Print("*                            *");
            Locate(x, y + 7); Print("*                            *");
            Locate(x, y + 8); Print("*                            *");
            Locate(x, y + 9); Print("******************************");
        }

        ////////////////////////////////////////

        ////////////////////////////////////////

        static void PeriodicString()
        {
            Print("Enter a string: ");
            string str = Console.ReadLine();
            bool checkIfPeriodic = false;

            if (PrimeCheck(str.Length) == true) AltCheck(str);
            else
            {
                for (int totalSubStrParts = 2; totalSubStrParts <= str.Length - 1; ++totalSubStrParts)
                {
                    if (str.Length % totalSubStrParts == 0)
                    {
                        checkIfPeriodic = Check(str, str.Length / totalSubStrParts, totalSubStrParts);

                        if (checkIfPeriodic == true)
                        {
                            Print("Is a periodical string\n"); break;
                        }
                    }
                }
            }

            if (checkIfPeriodic == false && PrimeCheck(str.Length) == false) Print("Not a periodical string\n");
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

            for (int i = 0; i < subLen; ++i)
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

            Console.ForegroundColor = ConsoleColor.White;
            return strCheck;
        }

        static void AltCheck(string str)
        {
            bool strCheck = true;

            for (int i = 0; i < str.Length - 1; ++i)
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

        ////////////////////////////////////////

        ////////////////////////////////////////

        static void AsciiTable()
        {
            WinSize(81, 41);

            int n = 1;
            Page(n);

            while (true)
            {
                if (Console.KeyAvailable == true)
                {
                    char numCh = Getch();

                    if (numCh == 'a')
                    {
                        Console.Beep(500, 50);
                        --n;
                        if (n == 0) n = 4;
                        CLS(); Page(n);
                    }
                    else if (numCh == 'd')
                    {
                        Console.Beep(500, 50);
                        ++n;
                        if (n == 5) n = 1;
                        CLS(); Page(n);
                    }
                    else if (numCh == 'k')
                    {
                        Console.Beep(500, 50);
                        break;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Locate(0, 35);
        }

        static void Page(int n)
        {
            if (n == 1)      PageOne();
            else if (n == 2) PageTwo();
            else if (n == 3) PageThree();
            else if (n == 4) PageFour();
        }

        static void PageOne()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");

            for (int i = 0; i <= 31; ++i)
            {
                if (i >= 7 && i <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Print($"  {i}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Print("\t\t"); PrintBinary(i);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Print("\t\t"); PrintHex(i);

                    Print("\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Print($"  {i}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Print("\t\t"); PrintBinary(i);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Print("\t\t"); PrintHex(i);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Print("\t\t"); PrintAsciiLetter(i);

                    Print("\n");
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Locate(15, 37); Print("Nhan AD de chuyen trang va k de thoat");
        }

        static void PageTwo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");

            for (int i = 32; i <= 63; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Print($"  {i}");

                Console.ForegroundColor = ConsoleColor.Green;
                Print("\t\t"); PrintBinary(i);

                Console.ForegroundColor = ConsoleColor.Red;
                Print("\t\t"); PrintHex(i);

                Console.ForegroundColor = ConsoleColor.Blue;
                Print("\t\t"); PrintAsciiLetter(i);

                Print("\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Locate(15, 37); Print("Nhan AD de chuyen trang va k de thoat");
        }

        static void PageThree()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");

            for (int i = 64; i <= 95; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Print($"  {i}");

                Console.ForegroundColor = ConsoleColor.Green;
                Print("\t\t"); PrintBinary(i);

                Console.ForegroundColor = ConsoleColor.Red;
                Print("\t\t"); PrintHex(i);

                Console.ForegroundColor = ConsoleColor.Blue;
                Print("\t\t"); PrintAsciiLetter(i);

                Print("\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Locate(15, 37); Print("Nhan AD de chuyen trang va k de thoat");
        }

        static void PageFour()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("Decimal\t\tBinary\t\t    Hexadecimal\t      ASCII\n");

            for (int i = 96; i <= 127; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Print($"  {i}");

                Console.ForegroundColor = ConsoleColor.Green;
                Print("\t\t"); PrintBinary(i);

                Console.ForegroundColor = ConsoleColor.Red;
                Print("\t\t"); PrintHex(i);

                Console.ForegroundColor = ConsoleColor.Blue;
                Print("\t\t"); PrintAsciiLetter(i);

                Print("\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Locate(15, 37); Print("Nhan AD de chuyen trang va k de thoat");
        }

        static void PrintBinary(int n)
        {
            string str = "";
            int q = n, a;

            while (q != 0)
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
            if (n == 0) str = "00";

            Print($"{str}");
        }

        static string HexChar(int a)
        {
            string ch = "";

            if (a == 10) ch = "A";
            else if (a == 11) ch = "B";
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

        ////////////////////////////////////////

        ////////////////////////////////////////

        static void DrawTheRectangular()
        {
            WinSize(201, 61);

            Locate(80, 2); Print("Nhan WASD de di chuyen HCN va +- de thay doi kich thuoc");
            Locate(100, 3); Print("Nhan k de thoat");

            int x = 30, y = 15, oldx, oldy, n = 1, oldn;
            char ch;

            Size(n, x, y);

            while (true)
            {
                Size(n, x, y);

                oldn = n; oldx = x; oldy = y;

                if (Console.KeyAvailable == true)
                {
                    ch = Getch();

                    if (ch == 'w')
                    {
                        --y;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == 's')
                    {
                        ++y;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == 'a')
                    {
                        --x;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == 'd')
                    {
                        ++x;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == '+')
                    {
                        ++n;
                        if (n == 11) n = 10;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == '-')
                    {
                        --n;
                        if (n == -1) n = 0;
                        SizeEmpty(oldn, oldx, oldy);
                    }
                    else if (ch == 'k') break;
                }
            }

            Locate(0, 60);
        }

        ////////////////////////////////////////

        static void Size(int n, int x, int y)
        {
            if (n == 0)       SizeZero(x, y);
            else if (n == 1)  SizeOne(x, y);
            else if (n == 2)  SizeTwo(x, y);
            else if (n == 3)  SizeThree(x, y);
            else if (n == 4)  SizeFour(x, y);
            else if (n == 5)  SizeFive(x, y);
            else if (n == 6)  SizeSix(x, y);
            else if (n == 7)  SizeSeven(x, y);
            else if (n == 8)  SizeEight(x, y);
            else if (n == 9)  SizeNine(x, y);
            else if (n == 10) SizeTen(x, y);
        }

        static void SizeEmpty(int n, int x, int y)
        {
            if (n == 0)       SizeZeroEmpty(x, y);
            else if (n == 1)  SizeOneEmpty(x, y);
            else if (n == 2)  SizeTwoEmpty(x, y);
            else if (n == 3)  SizeThreeEmpty(x, y);
            else if (n == 4)  SizeFourEmpty(x, y);
            else if (n == 5)  SizeFiveEmpty(x, y);
            else if (n == 6)  SizeSixEmpty(x, y);
            else if (n == 7)  SizeSevenEmpty(x, y);
            else if (n == 8)  SizeEightEmpty(x, y);
            else if (n == 9)  SizeNineEmpty(x, y);
            else if (n == 10) SizeTenEmpty(x, y);
        }

        ////////////////////////////////////////

        static void SizeZero(int x, int y)
        {
            Locate(x, y);     Print("..");
            Locate(x, y + 1); Print("..");
        }

        static void SizeZeroEmpty(int x, int y)
        {
            Locate(x, y);     Print("  ");
            Locate(x, y + 1); Print("  ");
        }

        ////////////////////////////////////////

        static void SizeOne(int x, int y)
        {
            Locate(x, y);     Print(".....");
            Locate(x, y + 1); Print(".....");
            Locate(x, y + 2); Print(".....");
        }

        static void SizeOneEmpty(int x, int y)
        {
            Locate(x, y);     Print("     ");
            Locate(x, y + 1); Print("     ");
            Locate(x, y + 2); Print("     ");
        }

        ////////////////////////////////////////

        static void SizeTwo(int x, int y)
        {
            Locate(x, y);     Print("........");
            Locate(x, y + 1); Print("........");
            Locate(x, y + 2); Print("........");
            Locate(x, y + 3); Print("........");
        }

        static void SizeTwoEmpty(int x, int y)
        {
            Locate(x, y);     Print("        ");
            Locate(x, y + 1); Print("        ");
            Locate(x, y + 2); Print("        ");
            Locate(x, y + 3); Print("        ");
        }

        ////////////////////////////////////////

        static void SizeThree(int x, int y)
        {
            Locate(x, y);     Print("...........");
            Locate(x, y + 1); Print("...........");
            Locate(x, y + 2); Print("...........");
            Locate(x, y + 3); Print("...........");
            Locate(x, y + 4); Print("...........");
        }

        static void SizeThreeEmpty(int x, int y)
        {
            Locate(x, y);     Print("           ");
            Locate(x, y + 1); Print("           ");
            Locate(x, y + 2); Print("           ");
            Locate(x, y + 3); Print("           ");
            Locate(x, y + 4); Print("           ");
        }

        ////////////////////////////////////////

        static void SizeFour(int x, int y)
        {
            Locate(x, y);     Print("..............");
            Locate(x, y + 1); Print("..............");
            Locate(x, y + 2); Print("..............");
            Locate(x, y + 3); Print("..............");
            Locate(x, y + 4); Print("..............");
            Locate(x, y + 5); Print("..............");
        }

        static void SizeFourEmpty(int x, int y)
        {
            Locate(x, y);     Print("              ");
            Locate(x, y + 1); Print("              ");
            Locate(x, y + 2); Print("              ");
            Locate(x, y + 3); Print("              ");
            Locate(x, y + 4); Print("              ");
            Locate(x, y + 5); Print("              ");
        }

        ////////////////////////////////////////

        static void SizeFive(int x, int y)
        {
            Locate(x, y);     Print(".................");
            Locate(x, y + 1); Print(".................");
            Locate(x, y + 2); Print(".................");
            Locate(x, y + 3); Print(".................");
            Locate(x, y + 4); Print(".................");
            Locate(x, y + 5); Print(".................");
            Locate(x, y + 6); Print(".................");
        }

        static void SizeFiveEmpty(int x, int y)
        {
            Locate(x, y);     Print("                 ");
            Locate(x, y + 1); Print("                 ");
            Locate(x, y + 2); Print("                 ");
            Locate(x, y + 3); Print("                 ");
            Locate(x, y + 4); Print("                 ");
            Locate(x, y + 5); Print("                 ");
            Locate(x, y + 6); Print("                 ");
        }

        ////////////////////////////////////////

        static void SizeSix(int x, int y)
        {
            Locate(x, y);     Print("....................");
            Locate(x, y + 1); Print("....................");
            Locate(x, y + 2); Print("....................");
            Locate(x, y + 3); Print("....................");
            Locate(x, y + 4); Print("....................");
            Locate(x, y + 5); Print("....................");
            Locate(x, y + 6); Print("....................");
            Locate(x, y + 7); Print("....................");
        }

        static void SizeSixEmpty(int x, int y)
        {
            Locate(x, y);     Print("                    ");
            Locate(x, y + 1); Print("                    ");
            Locate(x, y + 2); Print("                    ");
            Locate(x, y + 3); Print("                    ");
            Locate(x, y + 4); Print("                    ");
            Locate(x, y + 5); Print("                    ");
            Locate(x, y + 6); Print("                    ");
            Locate(x, y + 7); Print("                    ");
        }

        ////////////////////////////////////////

        static void SizeSeven(int x, int y)
        {
            Locate(x, y);     Print(".......................");
            Locate(x, y + 1); Print(".......................");
            Locate(x, y + 2); Print(".......................");
            Locate(x, y + 3); Print(".......................");
            Locate(x, y + 4); Print(".......................");
            Locate(x, y + 5); Print(".......................");
            Locate(x, y + 6); Print(".......................");
            Locate(x, y + 7); Print(".......................");
            Locate(x, y + 8); Print(".......................");
        }

        static void SizeSevenEmpty(int x, int y)
        {
            Locate(x, y);     Print("                       ");
            Locate(x, y + 1); Print("                       ");
            Locate(x, y + 2); Print("                       ");
            Locate(x, y + 3); Print("                       ");
            Locate(x, y + 4); Print("                       ");
            Locate(x, y + 5); Print("                       ");
            Locate(x, y + 6); Print("                       ");
            Locate(x, y + 7); Print("                       ");
            Locate(x, y + 8); Print("                       ");
        }

        ////////////////////////////////////////

        static void SizeEight(int x, int y)
        {
            Locate(x, y);     Print("..........................");
            Locate(x, y + 1); Print("..........................");
            Locate(x, y + 2); Print("..........................");
            Locate(x, y + 3); Print("..........................");
            Locate(x, y + 4); Print("..........................");
            Locate(x, y + 5); Print("..........................");
            Locate(x, y + 6); Print("..........................");
            Locate(x, y + 7); Print("..........................");
            Locate(x, y + 8); Print("..........................");
            Locate(x, y + 9); Print("..........................");
        }

        static void SizeEightEmpty(int x, int y)
        {
            Locate(x, y);     Print("                          ");
            Locate(x, y + 1); Print("                          ");
            Locate(x, y + 2); Print("                          ");
            Locate(x, y + 3); Print("                          ");
            Locate(x, y + 4); Print("                          ");
            Locate(x, y + 5); Print("                          ");
            Locate(x, y + 6); Print("                          ");
            Locate(x, y + 7); Print("                          ");
            Locate(x, y + 8); Print("                          ");
            Locate(x, y + 9); Print("                          ");
        }

        ////////////////////////////////////////

        static void SizeNine(int x, int y)
        {
            Locate(x, y);      Print(".............................");
            Locate(x, y + 1);  Print(".............................");
            Locate(x, y + 2);  Print(".............................");
            Locate(x, y + 3);  Print(".............................");
            Locate(x, y + 4);  Print(".............................");
            Locate(x, y + 5);  Print(".............................");
            Locate(x, y + 6);  Print(".............................");
            Locate(x, y + 7);  Print(".............................");
            Locate(x, y + 8);  Print(".............................");
            Locate(x, y + 9);  Print(".............................");
            Locate(x, y + 10); Print(".............................");
        }

        static void SizeNineEmpty(int x, int y)
        {
            Locate(x, y);      Print("                             ");
            Locate(x, y + 1);  Print("                             ");
            Locate(x, y + 2);  Print("                             ");
            Locate(x, y + 3);  Print("                             ");
            Locate(x, y + 4);  Print("                             ");
            Locate(x, y + 5);  Print("                             ");
            Locate(x, y + 6);  Print("                             ");
            Locate(x, y + 7);  Print("                             ");
            Locate(x, y + 8);  Print("                             ");
            Locate(x, y + 9);  Print("                             ");
            Locate(x, y + 10); Print("                             ");
        }

        ////////////////////////////////////////

        static void SizeTen(int x, int y)
        {
            Locate(x, y);      Print("................................");
            Locate(x, y + 1);  Print("................................");
            Locate(x, y + 2);  Print("................................");
            Locate(x, y + 3);  Print("................................");
            Locate(x, y + 4);  Print("................................");
            Locate(x, y + 5);  Print("................................");
            Locate(x, y + 6);  Print("................................");
            Locate(x, y + 7);  Print("................................");
            Locate(x, y + 8);  Print("................................");
            Locate(x, y + 9);  Print("................................");
            Locate(x, y + 10); Print("................................");
            Locate(x, y + 11); Print("................................");
        }

        static void SizeTenEmpty(int x, int y)
        {
            Locate(x, y);      Print("                                ");
            Locate(x, y + 1);  Print("                                ");
            Locate(x, y + 2);  Print("                                ");
            Locate(x, y + 3);  Print("                                ");
            Locate(x, y + 4);  Print("                                ");
            Locate(x, y + 5);  Print("                                ");
            Locate(x, y + 6);  Print("                                ");
            Locate(x, y + 7);  Print("                                ");
            Locate(x, y + 8);  Print("                                ");
            Locate(x, y + 9);  Print("                                ");
            Locate(x, y + 10); Print("                                ");
            Locate(x, y + 11); Print("                                ");
        }

        //////////////////////////////////////


        //////////////////////////////////////

        static void TheGame()
        {
            Instruction();

            string ans;
            do
            {
                CLS();
                StartTheGame();

                do
                {
                    Locate(134, 58); Print("          ");
                    Locate(100, 58); Print("Ban co muon tiep tuc choi(y/n) ?: ");
                    ans = Console.ReadLine();
                } while (!(ans == "y" || ans == "n"));

            } while (ans == "y");

            Locate(100, 27); Print("Cam on ban da choi");
            Locate(0, 60);
        }

        //////////////////////////////////////

        static void Instruction()
        {
            WinSize(100, 51);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Locate(28, 20); Print("Nhan WASD de di chuyen vat hoac k de dung tro choi");
            Locate(25, 22); Print("Nhan phim so sao cho so hien tren vat trung voi vat roi");
            Locate(25, 24); Print("Neu so tren vat khong giong voi vat roi ban bi tru diem");
            Locate(35, 26); Print("Ban thang tro choi khi dat du 50 diem");
            Locate(35, 28); Print("Ban thua khi suc manh cua khien con 0%");
            Locate(38, 30); Print("Thu thap X2 Speed de tang toc do");
            Locate(32, 32); Print("Thu thap +1 Shield de tang suc manh cho khien");
            Locate(40, 34); Print("Nhan phim ESC de tiep tuc");
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                if (Console.KeyAvailable == true)
                {
                    int ch = Getch();
                    if (ch == 27)
                    {
                        Console.Beep(500, 50);
                        break;
                    }
                }
            }
        }

        //////////////////////////////////////

        static void StartTheGame()
        {
            WinSize(240, 61);

            int basketX = 90, basketY = 46;
            int score, maxScoreToIncrementY, shield, basketNum;

            int[] arrayOfInfo = GroundOne(basketX, basketY);

            basketX = arrayOfInfo[0];
            basketY = arrayOfInfo[1];
            score = arrayOfInfo[2];
            maxScoreToIncrementY = arrayOfInfo[3];
            shield = arrayOfInfo[4];
            basketNum = arrayOfInfo[5];

            if(shield != 0)
            {
                CLS();
                Console.ForegroundColor = ConsoleColor.White;
                Border();

                GroundTwo(basketX, basketY, score, maxScoreToIncrementY, shield, basketNum);
            }
            else
            {
                Locate(100, 25); Print("You Lose!");
            }

            Locate(0, 60);
        }

        //////////////////////////////////////

        static void GroundTwo(int basketX, int basketY, int score, int maxScoreToIncrementY, int shield, int basketNum)
        {
            Border();
            Locate(210, 5); Print("Ground Two");

            int oldBasketX;
            char ch;

            Random rand = new Random();

            int numberN = rand.Next(1, 10);
            int numberX = rand.Next(4, 184);
            int numberY = 1;
            int oldNumberX, oldNumberY;

            int timeLeftToIncrementY = 70, totalTime = 70;

            bool collision = false, wrongNumber = false;

            //////////////////////////////////////

            int numberN_Copy = rand.Next(1, 10);
            int numberX_Copy = rand.Next(4, 184);
            int numberY_Copy = 1;
            int oldNumberX_Copy, oldNumberY_Copy;
            int NumberCopyAppearanceTimeLeft = 1000;

            bool collision_Copy = false, wrongNumber_Copy = false;

            //////////////////////////////////////


            int SpeedBlockX = rand.Next(4, 184);
            int SpeedBlockY = 1, oldSpeedBlockX, oldSpeedBlockY;
            int time = 8000, timeToIncreaseY = 90, totalTimeToIncreaseY = 90;
            int XSpeedTime = 4000, speed = 2;
            bool getHit = false, hittingBasket = false;

            int initColor = 0;
            //////////////////////////////////////

            //////////////////////////////////////


            int ShieldBlockX = rand.Next(4, 184);
            int ShieldBlockY = 1, oldShieldBlockX, oldShieldBlockY;
            int timeShieldOccurr = 9000, ShieldTimeToIncreaseY = 90, totalShieldTimeToIncreaseY = 90;
            
            bool ShieldgetHit = false, ShieldhittingBasket = false;
            
            //////////////////////////////////////


            Basket(basketNum, basketX, basketY);
            Number(numberN, numberX, numberY);

            while (shield > 0 && score < 50)
            {
                //////////////////////////////////////

                oldBasketX = basketX;

                //////////////////////////////////////

                ScorePoint(score); ShieldWall(shield);
                
                //////////////////////////////////////

                --time; //////////////////////////////

                if (time <= 0)
                {
                    if (time == 0)
                    {
                        SpeedBlockX = rand.Next(4, 184);
                        SpeedBlockY = 1;
                        timeToIncreaseY = totalTimeToIncreaseY;
                    }

                    XSpeedPower(SpeedBlockX, SpeedBlockY);

                    oldSpeedBlockX = SpeedBlockX; oldSpeedBlockY = SpeedBlockY;

                    --timeToIncreaseY;

                    if (timeToIncreaseY == 0)
                    {
                        ++SpeedBlockY;

                        XSpeedLineEmpty(oldSpeedBlockX, oldSpeedBlockY);
                        timeToIncreaseY = totalTimeToIncreaseY;
                    }

                    if (SpeedBlockY + 8 == 55)
                    {
                        XSpeedPowerEmpty(oldSpeedBlockX, oldSpeedBlockY);

                        getHit = true;
                    }


                    if ((SpeedBlockX + 14) > basketX && SpeedBlockX <= basketX && (SpeedBlockY + 8) >= 46)
                    {
                        XSpeedPowerEmpty(oldSpeedBlockX, oldSpeedBlockY);

                        getHit = true; hittingBasket = true;
                    }
                    else if (SpeedBlockX < (basketX + 25) && (SpeedBlockX + 14) >= (basketX + 25) && (SpeedBlockY + 8) >= 46)
                    {
                        XSpeedPowerEmpty(oldSpeedBlockX, oldSpeedBlockY);

                        getHit = true; hittingBasket = true;
                    }
                    else if (SpeedBlockX >= basketX && (SpeedBlockX + 14) <= (basketX + 25) && (SpeedBlockY + 8) >= 46)
                    {
                        XSpeedPowerEmpty(oldSpeedBlockX, oldSpeedBlockY);

                        getHit = true; hittingBasket = true;
                    }

                    if (getHit == true)
                    {
                        time = 8000; initColor = 1;
                        getHit = false;

                        if (hittingBasket == true)
                        {
                            speed = 4;

                            if (basketX % 2 != 0)
                            {
                                BasketEmpty(oldBasketX, basketY);
                                while (basketX % 2 != 0)
                                {
                                    ++basketX;
                                }
                            }
                        }
                    }
                }

                if (hittingBasket == true)
                {
                    --XSpeedTime;
                    if (XSpeedTime == 0)
                    {
                        speed = 2;
                        hittingBasket = false;
                        XSpeedTime = 4000;
                    }

                    if(initColor == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Basket(basketNum, basketX, basketY);
                        Console.Beep(800, 100);
                        Console.ForegroundColor = ConsoleColor.White;
                        initColor = 0;
                    }
                }

                //////////////////////////////////////

                --timeShieldOccurr; //////////////////////////////    

                if (timeShieldOccurr <= 0)
                {
                    if (timeShieldOccurr == 0)
                    {
                        ShieldBlockX = rand.Next(4, 184);
                        ShieldBlockY = 1;
                        ShieldTimeToIncreaseY = totalShieldTimeToIncreaseY;
                    }

                    ShieldPlus(ShieldBlockX, ShieldBlockY);

                    oldShieldBlockX = ShieldBlockX; oldShieldBlockY = ShieldBlockY;

                    --ShieldTimeToIncreaseY;

                    if (ShieldTimeToIncreaseY == 0)
                    {
                        ++ShieldBlockY;

                        ShieldPlusLineEmpty(oldShieldBlockX, oldShieldBlockY);
                        ShieldTimeToIncreaseY = totalShieldTimeToIncreaseY;
                    }

                    if (ShieldBlockY + 8 == 55)
                    {
                        ShieldPlusEmpty(oldShieldBlockX, oldShieldBlockY);

                        ShieldgetHit = true;
                    }


                    if ((ShieldBlockX + 14) > basketX && ShieldBlockX <= basketX && (ShieldBlockY + 8) >= 46)
                    {
                        ShieldPlusEmpty(oldShieldBlockX, oldShieldBlockY);

                        ShieldgetHit = true; ShieldhittingBasket = true;
                    }
                    else if (ShieldBlockX < (basketX + 25) && (ShieldBlockX + 14) >= (basketX + 25) && (ShieldBlockY + 8) >= 46)
                    {
                        ShieldPlusEmpty(oldShieldBlockX, oldShieldBlockY);

                        ShieldgetHit = true; ShieldhittingBasket = true;
                    }
                    else if (ShieldBlockX >= basketX && (ShieldBlockX + 14) <= (basketX + 25) && (ShieldBlockY + 8) >= 46)
                    {
                        ShieldPlusEmpty(oldShieldBlockX, oldShieldBlockY);

                        ShieldgetHit = true; ShieldhittingBasket = true;
                    }

                    if (ShieldgetHit == true)
                    {
                        timeShieldOccurr = 9000;
                        ShieldgetHit = false;

                        if (ShieldhittingBasket == true)
                        {
                            shield += 10;

                            if (shield > 100) shield = 100;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Basket(basketNum, basketX, basketY);
                            Console.Beep(800, 100);
                            Console.ForegroundColor = ConsoleColor.White;

                            ShieldhittingBasket = false;
                        }
                    }
                }

                //////////////////////////////////////

                oldNumberX = numberX; oldNumberY = numberY;
                oldNumberX_Copy = numberX_Copy; oldNumberY_Copy = numberY_Copy;

                //////////////////////////////////////

                Number(numberN, numberX, numberY);

                //////////////////////////////////////

                if (NumberCopyAppearanceTimeLeft >= 0)
                {
                    --NumberCopyAppearanceTimeLeft;
                    numberY_Copy = 1;
                }

                if (NumberCopyAppearanceTimeLeft < 0) NumberCopy(numberN_Copy, numberX_Copy, numberY_Copy);

                //////////////////////////////////////

                --timeLeftToIncrementY;

                if (timeLeftToIncrementY == 0)
                {
                    ++numberY;
                    ++numberY_Copy;

                    NumberLineEmpty(oldNumberX, oldNumberY);
                    NumberLineEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    timeLeftToIncrementY = totalTime;

                    if (score == maxScoreToIncrementY)
                    {
                        totalTime -= 10;
                        maxScoreToIncrementY += 10;
                    }
                }

                //////////////////////////////////////

                if (numberY + 8 == 55) 
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    Console.ForegroundColor = ConsoleColor.Red;
                    BottomBorder();

                    Console.Beep(1600, 100);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    BottomBorder();

                    shield -= 10;

                    if (shield == 0) ShieldWall(shield);
                }

                //////////////////////////////////////

                if (numberY_Copy + 8 == 55) 
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    Console.ForegroundColor = ConsoleColor.Red;
                    BottomBorder();

                    Console.Beep(1600, 100);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    BottomBorder();

                    shield -= 10;

                    if (shield == 0) ShieldWall(shield);
                }

                //////////////////////////////////////

                if ((numberX + 14) > basketX && numberX <= basketX && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }
                else if (numberX < (basketX + 25) && (numberX + 14) >= (basketX + 25) && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }
                else if (numberX >= basketX && (numberX + 14) <= (basketX + 25) && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }

                //////////////////////////////////////

                if ((numberX_Copy + 14) > basketX && numberX_Copy <= basketX && (numberY_Copy + 8) >= 46 && numberN_Copy == basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    collision_Copy = true;
                }
                else if (numberX_Copy < (basketX + 25) && (numberX_Copy + 14) >= (basketX + 25) && (numberY_Copy + 8) >= 46 && numberN_Copy == basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    collision_Copy = true;
                }
                else if (numberX_Copy >= basketX && (numberX_Copy + 14) <= (basketX + 25) && (numberY_Copy + 8) >= 46 && numberN_Copy == basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    collision_Copy = true;
                }

                //////////////////////////////////////

                if ((numberX + 14) > basketX && numberX <= basketX && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }
                else if (numberX < (basketX + 25) && (numberX + 14) >= (basketX + 25) && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }
                else if (numberX >= basketX && (numberX + 14) <= (basketX + 25) && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }

                //////////////////////////////////////

                if ((numberX_Copy + 14) > basketX && numberX_Copy <= basketX && (numberY_Copy + 8) >= 46 && numberN_Copy != basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    wrongNumber_Copy = true;
                }
                else if (numberX_Copy < (basketX + 25) && (numberX_Copy + 14) >= (basketX + 25) && (numberY_Copy + 8) >= 46 && numberN_Copy != basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    wrongNumber_Copy = true;
                }
                else if (numberX_Copy >= basketX && (numberX_Copy + 14) <= (basketX + 25) && (numberY_Copy + 8) >= 46 && numberN_Copy != basketNum)
                {
                    NumberEmptyCopy(oldNumberX_Copy, oldNumberY_Copy);

                    numberY_Copy = 1;
                    numberN_Copy = rand.Next(1, 10);
                    numberX_Copy = rand.Next(4, 184);

                    wrongNumber_Copy = true;
                }

                //////////////////////////////////////


                //////////////////////////////////////

                if (collision == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Basket(basketNum, basketX, basketY);
                }
                else if (collision == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Basket(basketNum, basketX, basketY);
                    Console.Beep(800, 100);
                    collision = false;
                    ++score;
                }

                //////////////////////////////////////

                if (collision_Copy == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Basket(basketNum, basketX, basketY);
                }
                else if (collision_Copy == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Basket(basketNum, basketX, basketY);
                    Console.Beep(800, 100);
                    collision_Copy = false;
                    ++score;
                }

                //////////////////////////////////////

                if (wrongNumber == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Basket(basketNum, basketX, basketY);

                    Console.Beep(1600, 100);
                    
                    wrongNumber = false;

                    --score;
                }

                //////////////////////////////////////

                if (wrongNumber_Copy == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Basket(basketNum, basketX, basketY);

                    Console.Beep(1600, 100);

                    for (long i = 100000000; i >= 0; --i) ;

                    wrongNumber_Copy = false;

                    --score;
                }

                //////////////////////////////////////

                if (Console.KeyAvailable == true)
                {
                    ch = Getch();

                    if (ch == 'a')
                    {
                        basketX -= speed;
                        if (basketX <= 2) basketX = 4;
                        BasketEmpty(oldBasketX, basketY);
                    }
                    else if (ch == 'd')
                    {
                        basketX += speed;
                        if (basketX >= 174) basketX = 172;
                        BasketEmpty(oldBasketX, basketY);
                    }
                    else if (ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                    {
                        basketNum = int.Parse(ch.ToString());
                        BasketEmpty(oldBasketX, basketY);

                        Console.Beep(600, 10);
                    }
                    else if (ch == 'k') break;
                }
            }

            if(shield <= 0)
            {
                Locate(100, 25); Print("You Lose!");
            }
            else
            {
                Locate(100, 25); Print("You Win!");
            }
        }

        /////////////////////////////////////////////////

        static int[] GroundOne(int basketX, int basketY)
        {
            Border();
            Locate(210, 5); Print("Ground One");
            
            int[] arrayOfInfo = new int[6];

            int basketNum = 1, oldBasketX;
            char ch;

            Random rand = new Random();

            int numberN = rand.Next(1, 10);
            int numberX = rand.Next(4, 184);
            int numberY = 1;
            int oldNumberX, oldNumberY;

            int timeLeftToIncrementY = 90, totalTime = 90;
            int score = 0, maxScoreToIncrementY = 10;
            int shield = 100;

            bool collision = false, wrongNumber = false;

            Basket(basketNum, basketX, basketY);
            Number(numberN, numberX, numberY);

            while (shield > 0 && score < 10)
            {
                ScorePoint(score); ShieldWall(shield);

                //////////////////////////////////////


                //////////////////////////////////////

                oldNumberX = numberX; oldNumberY = numberY;

                Number(numberN, numberX, numberY);

                //////////////////////////////////////

                --timeLeftToIncrementY;

                if (timeLeftToIncrementY == 0)
                {
                    ++numberY;
                    NumberLineEmpty(oldNumberX, oldNumberY);

                    timeLeftToIncrementY = totalTime;

                    if(score == maxScoreToIncrementY)
                    {
                        totalTime -= 10;
                        maxScoreToIncrementY += 10;
                    }
                }

                //////////////////////////////////////

                if (numberY + 8 == 55) //55 46
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    Console.ForegroundColor = ConsoleColor.Red;
                    BottomBorder();

                    Console.Beep(1600, 100);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    BottomBorder();

                    shield -= 10;

                    if(shield == 0) ShieldWall(shield);
                }

                //////////////////////////////////////

                if ((numberX + 14) > basketX && numberX <= basketX && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }
                else if (numberX < (basketX + 25) && (numberX + 14) >= (basketX + 25) && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }
                else if (numberX >= basketX && (numberX + 14) <= (basketX + 25) && (numberY + 8) >= 46 && numberN == basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    collision = true;
                }

                //////////////////////////////////////

                if ((numberX + 14) > basketX && numberX <= basketX && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }
                else if (numberX < (basketX + 25) && (numberX + 14) >= (basketX + 25) && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }
                else if (numberX >= basketX && (numberX + 14) <= (basketX + 25) && (numberY + 8) >= 46 && numberN != basketNum)
                {
                    NumberEmpty(oldNumberX, oldNumberY);

                    numberY = 1;
                    numberN = rand.Next(1, 10);
                    numberX = rand.Next(4, 184);

                    wrongNumber = true;
                }

                //////////////////////////////////////

                oldBasketX = basketX;

                //////////////////////////////////////

                if (collision == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Basket(basketNum, basketX, basketY);
                }
                else if (collision == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Basket(basketNum, basketX, basketY);
                    
                    Console.Beep(800, 100);

                    for (long i = 100000000; i >= 0; --i) ;
                    
                    collision = false;

                    ++score;
                }

                //////////////////////////////////////

                if (wrongNumber == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Basket(basketNum, basketX, basketY);
                    
                    Console.Beep(1600, 100);

                    for (long i = 100000000; i >= 0; --i) ;

                    wrongNumber = false;

                    --score;
                }

                //////////////////////////////////////

                if (Console.KeyAvailable == true)
                {
                    ch = Getch();

                    if (ch == 'a')
                    {
                        basketX -= 2;
                        if (basketX == 2) basketX = 4;
                        BasketEmpty(oldBasketX, basketY);
                    }
                    else if (ch == 'd')
                    {
                        basketX += 2;
                        if (basketX == 174) basketX = 172;
                        BasketEmpty(oldBasketX, basketY);
                    }
                    else if (ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                    {
                        basketNum = int.Parse(ch.ToString());
                        BasketEmpty(oldBasketX, basketY);

                        Console.Beep(600, 10);
                    }
                    else if (ch == 'k') break;
                }
            }

            arrayOfInfo[0] = basketX;
            arrayOfInfo[1] = basketY;
            arrayOfInfo[2] = score;
            arrayOfInfo[3] = maxScoreToIncrementY;
            arrayOfInfo[4] = shield;
            arrayOfInfo[5] = basketNum;

            return arrayOfInfo;
        }

        /////////////////////////////////////////////////

        static void ScorePoint(int score)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Locate(221, 1); Print("    ");
            if (score < 0) score = 0; 
            Locate(210, 1); Print($"Your score: {score}");
        }

        static void ShieldWall(int shieldPower)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Locate(223, 2); Print("    ");
            Locate(210, 2); Print($"Shield power: {shieldPower}%");
        }

        /////////////////////////////////////////////////

        static void Basket(int n, int x, int y)
        {
            Locate(x, y);     Print("|------------------------|"); 
            Locate(x, y + 1); Print("|                        |");
            Locate(x, y + 2); Print("|                        |");
            Locate(x, y + 3); Print("|                        |");
            Locate(x, y + 4); Print("|                        |");
            Locate(x, y + 5); Print("|                        |");
            Locate(x, y + 6); Print("\\                        /");
            Locate(x, y + 7); Print(" \\                      / ");
            Locate(x, y + 8); Print("  \\____________________/  ");

            Locate(x + 2, y + 1); Print($"{n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n}");
            Locate(x + 2, y + 3); Print($"{n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n}");
            Locate(x + 2, y + 5); Print($"{n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n} {n}");
            Locate(x + 4, y + 7); Print($"{n} {n} {n} {n} {n} {n} {n} {n} {n} {n}");
        }

        static void BasketEmpty(int x, int y)
        {
            Locate(x, y);     Print("                          ");
            Locate(x, y + 1); Print("                          ");
            Locate(x, y + 2); Print("                          ");
            Locate(x, y + 3); Print("                          ");
            Locate(x, y + 4); Print("                          ");
            Locate(x, y + 5); Print("                          ");
            Locate(x, y + 6); Print("                          ");
            Locate(x, y + 7); Print("                          ");
            Locate(x, y + 8); Print("                          ");
        }

        /////////////////////////////////////////////////

        static void Border()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            TopBorder();
            BottomBorder();
            LeftBorder();
            RightBorder();
        }

        /////////////////////////////////////////////////

        static void TopBorder()
        {
            for(int x = 1; x <= 200; ++x)
            {
                Locate(x, 0); Print("_");
            }
        }

        static void BottomBorder() 
        {
            for (int x = 1; x <= 200; ++x)
            {
                Locate(x, 55); Print("_");
            }
        }

        static void LeftBorder()
        {
            for(int y = 1; y <= 55; ++y)
            {
                Locate(1, y); Print("|");
            }
        }

        static void RightBorder()
        {
            for (int y = 1; y <= 55; ++y)
            {
                Locate(200, y); Print("|");
            }
        }

        /////////////////////////////////////////////////

        static void Number(int n, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (n == 1)      One(x, y);
            else if (n == 2) Two(x, y);
            else if (n == 3) Three(x, y);
            else if (n == 4) Four(x, y);
            else if (n == 5) Five(x, y);
            else if (n == 6) Six(x, y);
            else if (n == 7) Seven(x, y);
            else if (n == 8) Eight(x, y);
            else if (n == 9) Nine(x, y);
        }

        static void NumberLineEmpty(int x, int y)
        {
            Locate(x, y); Print("               ");
        }

        static void NumberEmpty(int x, int y)
        {
            Locate(x, y);     Print("               ");
            Locate(x, y + 1); Print("               ");
            Locate(x, y + 2); Print("               ");
            Locate(x, y + 3); Print("               ");
            Locate(x, y + 4); Print("               ");
            Locate(x, y + 5); Print("               ");
            Locate(x, y + 6); Print("               ");
            Locate(x, y + 7); Print("               ");
            Locate(x, y + 8); Print("               ");
        }

        /////////////////////////////////////////////////

        static void One(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /|      |");
            Locate(x, y + 2); Print("|    / |      |");
            Locate(x, y + 3); Print("|   /  |      |");
            Locate(x, y + 4); Print("|  /   |      |");
            Locate(x, y + 5); Print("|      |      |");
            Locate(x, y + 6); Print("|      |      |");
            Locate(x, y + 7); Print("|      |      |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Two(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /-\\     |");
            Locate(x, y + 2); Print("|    /   \\    |");
            Locate(x, y + 3); Print("|   /    |    |");
            Locate(x, y + 4); Print("|       /     |");
            Locate(x, y + 5); Print("|      /      |");
            Locate(x, y + 6); Print("|     /       |");
            Locate(x, y + 7); Print("|    /_____   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Three(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    /---\\    |");
            Locate(x, y + 2); Print("|   /     \\   |");
            Locate(x, y + 3); Print("|         /   |");
            Locate(x, y + 4); Print("|        |    |");
            Locate(x, y + 5); Print("|         \\   |");
            Locate(x, y + 6); Print("|   \\     /   |");
            Locate(x, y + 7); Print("|    \\___/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Four(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|       /     |");
            Locate(x, y + 2); Print("|      /      |");
            Locate(x, y + 3); Print("|     /       |");
            Locate(x, y + 4); Print("|    /   |    |");
            Locate(x, y + 5); Print("|   /____|__  |");
            Locate(x, y + 6); Print("|        |    |");
            Locate(x, y + 7); Print("|        |    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Five(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    |-----   |");
            Locate(x, y + 2); Print("|    |        |");
            Locate(x, y + 3); Print("|    |___     |");
            Locate(x, y + 4); Print("|        \\    |");
            Locate(x, y + 5); Print("|         \\   |");
            Locate(x, y + 6); Print("|    |    |   |");
            Locate(x, y + 7); Print("|    |___/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Six(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /---\\   |");
            Locate(x, y + 2); Print("|    /     \\  |");
            Locate(x, y + 3); Print("|   /         |");
            Locate(x, y + 4); Print("|   | /---\\   |");
            Locate(x, y + 5); Print("|   |/     \\  |");
            Locate(x, y + 6); Print("|    \\     /  |");
            Locate(x, y + 7); Print("|     \\___/   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Seven(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    ------/  |");
            Locate(x, y + 2); Print("|         /   |");
            Locate(x, y + 3); Print("|        /    |");
            Locate(x, y + 4); Print("|    ---/---  |");
            Locate(x, y + 5); Print("|      /      |");
            Locate(x, y + 6); Print("|     /       |");
            Locate(x, y + 7); Print("|    /        |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Eight(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /--\\    |");
            Locate(x, y + 2); Print("|    /    \\   |");
            Locate(x, y + 3); Print("|    \\    /   |");
            Locate(x, y + 4); Print("|     |--|    |");
            Locate(x, y + 5); Print("|    /    \\   |");
            Locate(x, y + 6); Print("|    \\    /   |");
            Locate(x, y + 7); Print("|     \\__/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void Nine(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    /-----\\  |");
            Locate(x, y + 2); Print("|   |       | |");
            Locate(x, y + 3); Print("|   |       | |");
            Locate(x, y + 4); Print("|    \\______| |");
            Locate(x, y + 5); Print("|           | |");
            Locate(x, y + 6); Print("|   \\      /  |");
            Locate(x, y + 7); Print("|    \\____/   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        /////////////////////////////////////////////////

        static void NumberCopy(int n, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (n == 1)      OneCopy(x, y);
            else if (n == 2) TwoCopy(x, y);
            else if (n == 3) ThreeCopy(x, y);
            else if (n == 4) FourCopy(x, y);
            else if (n == 5) FiveCopy(x, y);
            else if (n == 6) SixCopy(x, y);
            else if (n == 7) SevenCopy(x, y);
            else if (n == 8) EightCopy(x, y);
            else if (n == 9) NineCopy(x, y);
        }

        static void NumberLineEmptyCopy(int x, int y)
        {
            Locate(x, y); Print("               ");
        }

        static void NumberEmptyCopy(int x, int y)
        {
            Locate(x, y);     Print("               ");
            Locate(x, y + 1); Print("               ");
            Locate(x, y + 2); Print("               ");
            Locate(x, y + 3); Print("               ");
            Locate(x, y + 4); Print("               ");
            Locate(x, y + 5); Print("               ");
            Locate(x, y + 6); Print("               ");
            Locate(x, y + 7); Print("               ");
            Locate(x, y + 8); Print("               ");
        }

        /////////////////////////////////////////////////

        static void OneCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /|      |");
            Locate(x, y + 2); Print("|    / |      |");
            Locate(x, y + 3); Print("|   /  |      |");
            Locate(x, y + 4); Print("|  /   |      |");
            Locate(x, y + 5); Print("|      |      |");
            Locate(x, y + 6); Print("|      |      |");
            Locate(x, y + 7); Print("|      |      |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void TwoCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /-\\     |");
            Locate(x, y + 2); Print("|    /   \\    |");
            Locate(x, y + 3); Print("|   /    |    |");
            Locate(x, y + 4); Print("|       /     |");
            Locate(x, y + 5); Print("|      /      |");
            Locate(x, y + 6); Print("|     /       |");
            Locate(x, y + 7); Print("|    /_____   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void ThreeCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    /---\\    |");
            Locate(x, y + 2); Print("|   /     \\   |");
            Locate(x, y + 3); Print("|         /   |");
            Locate(x, y + 4); Print("|        |    |");
            Locate(x, y + 5); Print("|         \\   |");
            Locate(x, y + 6); Print("|   \\     /   |");
            Locate(x, y + 7); Print("|    \\___/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void FourCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|       /     |");
            Locate(x, y + 2); Print("|      /      |");
            Locate(x, y + 3); Print("|     /       |");
            Locate(x, y + 4); Print("|    /   |    |");
            Locate(x, y + 5); Print("|   /____|__  |");
            Locate(x, y + 6); Print("|        |    |");
            Locate(x, y + 7); Print("|        |    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void FiveCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    |-----   |");
            Locate(x, y + 2); Print("|    |        |");
            Locate(x, y + 3); Print("|    |___     |");
            Locate(x, y + 4); Print("|        \\    |");
            Locate(x, y + 5); Print("|         \\   |");
            Locate(x, y + 6); Print("|    |    |   |");
            Locate(x, y + 7); Print("|    |___/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void SixCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /---\\   |");
            Locate(x, y + 2); Print("|    /     \\  |");
            Locate(x, y + 3); Print("|   /         |");
            Locate(x, y + 4); Print("|   | /---\\   |");
            Locate(x, y + 5); Print("|   |/     \\  |");
            Locate(x, y + 6); Print("|    \\     /  |");
            Locate(x, y + 7); Print("|     \\___/   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void SevenCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    ------/  |");
            Locate(x, y + 2); Print("|         /   |");
            Locate(x, y + 3); Print("|        /    |");
            Locate(x, y + 4); Print("|    ---/---  |");
            Locate(x, y + 5); Print("|      /      |");
            Locate(x, y + 6); Print("|     /       |");
            Locate(x, y + 7); Print("|    /        |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void EightCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|     /--\\    |");
            Locate(x, y + 2); Print("|    /    \\   |");
            Locate(x, y + 3); Print("|    \\    /   |");
            Locate(x, y + 4); Print("|     |--|    |");
            Locate(x, y + 5); Print("|    /    \\   |");
            Locate(x, y + 6); Print("|    \\    /   |");
            Locate(x, y + 7); Print("|     \\__/    |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void NineCopy(int x, int y)
        {
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|    /-----\\  |");
            Locate(x, y + 2); Print("|   |       | |");
            Locate(x, y + 3); Print("|   |       | |");
            Locate(x, y + 4); Print("|    \\______| |");
            Locate(x, y + 5); Print("|           | |");
            Locate(x, y + 6); Print("|   \\      /  |");
            Locate(x, y + 7); Print("|    \\____/   |");
            Locate(x, y + 8); Print("|_____________|");
        }

        /////////////////////////////////////////////////

        static void XSpeedPower(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|   /-----\\   |");
            Locate(x, y + 2); Print("|  /       \\  |");
            Locate(x, y + 3); Print("| /         \\ |");
            Locate(x, y + 4); Print("| | X2 SPEED| |");
            Locate(x, y + 5); Print("| \\         / |");
            Locate(x, y + 6); Print("|  \\       /  |");
            Locate(x, y + 7); Print("|   \\_____/   |");
            Locate(x, y + 8); Print("|-------------|");
        }

        static void XSpeedLineEmpty(int x, int y)
        {
            Locate(x, y);     Print("               ");
        }

        static void XSpeedPowerEmpty(int x, int y)
        {
            Locate(x, y);     Print("               ");
            Locate(x, y + 1); Print("               ");
            Locate(x, y + 2); Print("               ");
            Locate(x, y + 3); Print("               ");
            Locate(x, y + 4); Print("               ");
            Locate(x, y + 5); Print("               ");
            Locate(x, y + 6); Print("               ");
            Locate(x, y + 7); Print("               ");
            Locate(x, y + 8); Print("               ");
        }

        /////////////////////////////////////////////////

        static void ShieldPlus(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Locate(x, y);     Print("|-------------|");
            Locate(x, y + 1); Print("|   /-----\\   |");
            Locate(x, y + 2); Print("|  /       \\  |");
            Locate(x, y + 3); Print("| /         \\ |");
            Locate(x, y + 4); Print("| |+1 SHIELD| |");
            Locate(x, y + 5); Print("| \\         / |");
            Locate(x, y + 6); Print("|  \\       /  |");
            Locate(x, y + 7); Print("|   \\_____/   |");
            Locate(x, y + 8); Print("|-------------|");
        }

        static void ShieldPlusLineEmpty(int x, int y)
        {
            Locate(x, y);     Print("               ");
        }

        static void ShieldPlusEmpty(int x, int y)
        {
            Locate(x, y);     Print("               ");
            Locate(x, y + 1); Print("               ");
            Locate(x, y + 2); Print("               ");
            Locate(x, y + 3); Print("               ");
            Locate(x, y + 4); Print("               ");
            Locate(x, y + 5); Print("               ");
            Locate(x, y + 6); Print("               ");
            Locate(x, y + 7); Print("               ");
            Locate(x, y + 8); Print("               ");
        }

        /////////////////////////////////////////////////

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


/*Made by Zuki Erudo*/
/*2/11/2023*/
/*11:20 PM*/
/*Thanks for everything*/