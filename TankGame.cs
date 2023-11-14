using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class TankGame
    {
        static void Main()
        {
            Console.SetWindowSize(201, 61);

            int x = 100, y = 15, oldx, oldy;
            char ch, numCh = '8', oldNumCh;

            while (true)
            {
                oldx = x; oldy = y;
                oldNumCh = numCh;

                Tank(numCh, x, y);

                if (Console.KeyAvailable == true)
                {
                    ch = getch();

                    if (ch == '6' || ch == '4' || ch == '8' || ch == '2')
                    {
                        numCh = ch; TankEmpty(oldNumCh, x, y);
                    }

                    if (ch == 'w')
                    {
                        --y;
                        TankEmpty(numCh, oldx, oldy);
                    }
                    else if (ch == 's')
                    {
                        ++y;
                        TankEmpty(numCh, oldx, oldy);
                    }
                    else if (ch == 'a')
                    {
                        --x;
                        TankEmpty(numCh, oldx, oldy);
                    }
                    else if (ch == 'd')
                    {
                        ++x;
                        TankEmpty(numCh, oldx, oldy);
                    }
                    else if (ch == 'k') break;
                }
            }

            Locate(0, 27);
        }

        static void Tank(char numCh, int x, int y)
        {
            if (numCh == '6') TankRight(x, y);
            else if (numCh == '4') TankLeft(x, y);
            else if (numCh == '8') TankUp(x, y);
            else if (numCh == '2') TankDown(x, y);
        }

        static void TankEmpty(char numCh, int x, int y)
        {
            if (numCh == '6') TankRightEmpty(x, y);
            else if (numCh == '4') TankLeftEmpty(x, y);
            else if (numCh == '8') TankUpEmpty(x, y);
            else if (numCh == '2') TankDownEmpty(x, y);
        }

        static void TankRight(int x, int y)
        {
            Locate(x, y);                           Print("_______________");
            Locate(x, y + 1);                       Print("|    _____    |");
            Locate(x, y + 2);                       Print("|   / ___ \\   |");
            Locate(x, y + 3);                       Print("|  | |___| |--|--------[|||||]");
            Locate(x, y + 4);                       Print("|   \\     /   |");
            Locate(x, y + 5);                       Print("|    -----    |");
            Locate(x, y + 6);                       Print("|_____________|");
        }

        static void TankRightEmpty(int x, int y)
        {
            Locate(x, y);                           Print("               ");
            Locate(x, y + 1);                       Print("               ");
            Locate(x, y + 2);                       Print("               ");
            Locate(x, y + 3);                       Print("                              ");
            Locate(x, y + 4);                       Print("               ");
            Locate(x, y + 5);                       Print("               ");
            Locate(x, y + 6);                       Print("               ");
        }

        static void TankLeft(int x, int y)
        {
            Locate(x, y);                           Print("_______________");
            Locate(x, y + 1);                       Print("|    _____    |");
            Locate(x, y + 2);                       Print("|   / ___ \\   |");
            Locate(x - 15, y + 3);   Print("[|||||]--------|--| |___| |  |");
            Locate(x, y + 4);                       Print("|   \\     /   |");
            Locate(x, y + 5);                       Print("|    -----    |");
            Locate(x, y + 6);                       Print("|_____________|");
        }

        static void TankLeftEmpty(int x, int y)
        {
            Locate(x, y);                           Print("               ");
            Locate(x, y + 1);                       Print("               ");
            Locate(x, y + 2);                       Print("               ");
            Locate(x - 15, y + 3);   Print("                              ");
            Locate(x, y + 4);                       Print("               ");
            Locate(x, y + 5);                       Print("               ");
            Locate(x, y + 6);                       Print("               ");
        }

        static void TankUp(int x, int y)
        {
            Locate(x, y - 6);                       Print("       =       ");
            Locate(x, y - 5);                       Print("       =       ");
            Locate(x, y - 4);                       Print("       =       ");
            Locate(x, y - 3);                       Print("       |       ");
            Locate(x, y - 2);                       Print("       |       ");
            Locate(x, y - 1);                       Print("       |       ");
            Locate(x, y);                           Print("_______|_______");
            Locate(x, y + 1);                       Print("|    __|__    |");
            Locate(x, y + 2);                       Print("|   / _|_ \\   |");
            Locate(x, y + 3);                       Print("|  | |___| |  |");
            Locate(x, y + 4);                       Print("|   \\     /   |");
            Locate(x, y + 5);                       Print("|    -----    |");
            Locate(x, y + 6);                       Print("|_____________|");
        }

        static void TankUpEmpty(int x, int y)
        {
            Locate(x, y - 6);                       Print("               ");
            Locate(x, y - 5);                       Print("               ");
            Locate(x, y - 4);                       Print("               ");
            Locate(x, y - 3);                       Print("               ");
            Locate(x, y - 2);                       Print("               ");
            Locate(x, y - 1);                       Print("               ");
            Locate(x, y);                           Print("               ");
            Locate(x, y + 1);                       Print("               ");
            Locate(x, y + 2);                       Print("               ");
            Locate(x, y + 3);                       Print("               ");
            Locate(x, y + 4);                       Print("               ");
            Locate(x, y + 5);                       Print("               ");
            Locate(x, y + 6);                       Print("               ");
        }

        static void TankDown(int x, int y)
        {
            Locate(x, y);                           Print("_______________");
            Locate(x, y + 1);                       Print("|    _____    |");
            Locate(x, y + 2);                       Print("|   / ___ \\   |");
            Locate(x, y + 3);                       Print("|  | |___| |  |");
            Locate(x, y + 4);                       Print("|   \\  |  /   |");
            Locate(x, y + 5);                       Print("|    --|--    |");
            Locate(x, y + 6);                       Print("|______|______|");
            Locate(x, y + 7);                       Print("       |       ");
            Locate(x, y + 8);                       Print("       |       ");
            Locate(x, y + 9);                       Print("       |       ");
            Locate(x, y + 10);                      Print("       |       ");
            Locate(x, y + 11);                      Print("       =       ");
            Locate(x, y + 12);                      Print("       =       ");
            Locate(x, y + 13);                      Print("       =       ");
        }

        static void TankDownEmpty(int x, int y)
        {
            Locate(x, y);                           Print("               ");
            Locate(x, y + 1);                       Print("               ");
            Locate(x, y + 2);                       Print("               ");
            Locate(x, y + 3);                       Print("               ");
            Locate(x, y + 4);                       Print("               ");
            Locate(x, y + 5);                       Print("               ");
            Locate(x, y + 6);                       Print("               ");
            Locate(x, y + 7);                       Print("               ");
            Locate(x, y + 8);                       Print("               ");
            Locate(x, y + 9);                       Print("               ");
            Locate(x, y + 10);                      Print("               ");
            Locate(x, y + 11);                      Print("               ");
            Locate(x, y + 12);                      Print("               ");
            Locate(x, y + 13);                      Print("               ");
        }

        static char getch()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            return key.KeyChar;
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
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