using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class3
    {
        static void Main()
        {
            WinSize(201, 61);
            int x = 30, y = 15, oldx, oldy, n = 1, oldn;
            char ch;

            Size(n, x, y);

            while(true)
            {
                Size(n, x, y);

                oldn = n; oldx = x; oldy = y;

                if(Console.KeyAvailable == true)
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

        ////////////////////////////////////////

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

        static void Wait(long delay)
        {
            for (long wait = 0; wait < delay; ++wait) ;
        }
    }
}