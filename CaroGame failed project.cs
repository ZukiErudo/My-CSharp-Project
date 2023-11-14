using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace For_studying
{
    internal class For_studying
    {
        static int[] caseOne = { 1, 2, 3 };
        static int[] caseTwo = { 4, 5, 6 };
        static int[] caseThree = { 7, 8, 9 };
        static int[] caseFour = { 1, 4, 7 };
        static int[] caseFive = { 2, 5, 8 };
        static int[] caseSix = { 3, 6, 9 };
        static int[] caseSeven = { 1, 5, 9 };
        static int[] caseEight = { 3, 5, 7 };

        static int huTurnOne, huTurnTwo = 0, huTurnThree, huTurnFour, huTurnFive,
                   maTurnOne, maTurnTwo, maTurnThree, maTurnFour;

        static void Main()
        {
            Locate(11, 10); Console.WriteLine(" ");
            Locate(0, 10); Console.Write("Your turn: "); 
            huTurnOne = int.Parse(Console.ReadLine());
            HuCell(huTurnOne);
            FirstTurn(huTurnOne, huTurnTwo);

            Locate(11, 10); Console.WriteLine(" ");
            Locate(0, 10); Console.Write("Your turn: ");
            huTurnTwo = int.Parse(Console.ReadLine());
            HuCell(huTurnTwo);
            FirstTurn(huTurnOne, huTurnTwo);

            Locate(0,11);
        }

        static void FirstTurn(int m, int n)
        {
            int arrToChoose, cell;
            System.Random random = new System.Random();
            int num = random.Next(1, 4);
            
            if (m == 1)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseOne");
                        int[] choosenCell = caseOne;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 2)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFour");
                        int[] choosenCell = caseFour;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 3)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSeven");
                        int[] choosenCell = caseSeven;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseOne.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseOne[i] != m && caseOne[i] != n) MaCell(caseOne[i]);
                    }

                    if (caseFour.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFour[i] != m && caseFour[i] != n) MaCell(caseFour[i]);
                    }

                    if (caseSeven.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSeven[i] != m && caseSeven[i] != n) MaCell(caseSeven[i]);
                    }
                }
            }

            if (m == 3)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseOne");
                        int[] choosenCell = caseOne;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 2)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSix");
                        int[] choosenCell = caseSix;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 3)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseEight");
                        int[] choosenCell = caseEight;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseOne.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseOne[i] != m && caseOne[i] != n) MaCell(caseOne[i]);
                    }

                    if (caseSix.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSix[i] != m && caseSix[i] != n) MaCell(caseSix[i]);
                    }

                    if (caseEight.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseEight[i] != m && caseEight[i] != n) MaCell(caseEight[i]);
                    }
                }
            }

            if (m == 7)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseThree");
                        int[] choosenCell = caseThree;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 2)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFour");
                        int[] choosenCell = caseFour;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 3)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseEight");
                        int[] choosenCell = caseEight;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseThree.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseThree[i] != m && caseThree[i] != n) MaCell(caseThree[i]);
                    }

                    if (caseFour.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFour[i] != m && caseFour[i] != n) MaCell(caseFour[i]);
                    }

                    if (caseEight.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseEight[i] != m && caseEight[i] != n) MaCell(caseEight[i]);
                    }
                }
            }

            if (m == 9)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseThree");
                        int[] choosenCell = caseThree;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 2)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSix");
                        int[] choosenCell = caseSix;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 3)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSeven");
                        int[] choosenCell = caseSeven;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseThree.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseThree[i] != m && caseThree[i] != n) MaCell(caseThree[i]);
                    }

                    if (caseSix.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSix[i] != m && caseSix[i] != n) MaCell(caseSix[i]);
                    }

                    if (caseSeven.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSeven[i] != m && caseSeven[i] != n) MaCell(caseSeven[i]);
                    }
                }
            }

            if (m == 2)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseOne");
                        int[] choosenCell = caseOne;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFive");
                        int[] choosenCell = caseFive;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseOne.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseOne[i] != m && caseOne[i] != n) MaCell(caseOne[i]);
                    }

                    if (caseFive.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFive[i] != m && caseFive[i] != n) MaCell(caseFive[i]);
                    }
                }
            }

            if (m == 4)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseTwo");
                        int[] choosenCell = caseTwo;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFour");
                        int[] choosenCell = caseFour;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseTwo.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseTwo[i] != m && caseTwo[i] != n) MaCell(caseTwo[i]);
                    }

                    if (caseFour.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFour[i] != m && caseFour[i] != n) MaCell(caseFour[i]);
                    }
                }
            }

            if (m == 6)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseTwo");
                        int[] choosenCell = caseTwo;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSix");
                        int[] choosenCell = caseSix;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseTwo.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseTwo[i] != m && caseTwo[i] != n) MaCell(caseTwo[i]);
                    }

                    if (caseSix.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSix[i] != m && caseSix[i] != n) MaCell(caseSix[i]);
                    }
                }
            }

            if (m == 8)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseThree");
                        int[] choosenCell = caseThree;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFive");
                        int[] choosenCell = caseFive;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseThree.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseThree[i] != m && caseThree[i] != n) MaCell(caseThree[i]);
                    }

                    if (caseFive.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFive[i] != m && caseFive[i] != n) MaCell(caseFive[i]);
                    }
                }
            }

            num = random.Next(1, 5);

            if (m == 5)
            {
                if(n == 0)
                {
                    if (num == 1)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseTwo");
                        int[] choosenCell = caseTwo;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 2)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseFive");
                        int[] choosenCell = caseFive;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 3)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseSeven");
                        int[] choosenCell = caseSeven;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                    else if (num == 4)
                    {
                        Locate(10, 0); Console.WriteLine("choosen case is  caseEight");
                        int[] choosenCell = caseEight;

                        while (true)
                        {
                            arrToChoose = random.Next(0, 3);
                            Locate(10, 1); Console.WriteLine("choosen number is " + choosenCell[arrToChoose]);

                            if (m != choosenCell[arrToChoose])
                                break;
                        }

                        cell = choosenCell[arrToChoose];
                        MaCell(cell);
                    }
                }
                else
                {
                    if (caseTwo.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseTwo[i] != m && caseTwo[i] != n) MaCell(caseTwo[i]);
                    }

                    if (caseFive.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseFive[i] != m && caseFive[i] != n) MaCell(caseFive[i]);
                    }

                    if (caseSeven.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseSeven[i] != m && caseSeven[i] != n) MaCell(caseSeven[i]);
                    }

                    if (caseEight.Contains(n))
                    {
                        for (int i = 0; i <= 2; ++i)
                            if (caseEight[i] != m && caseEight[i] != n) MaCell(caseEight[i]);
                    }
                }
            }
        }

        static void SecondTurn(int m, int n)
        {

        }

        static void MaCell(int MaTurn)
        {
            if (MaTurn == 1) { Locate(0, 0); Console.WriteLine("x"); }
            else if (MaTurn == 2) { Locate(1, 0); Console.WriteLine("x"); }
            else if (MaTurn == 3) { Locate(2, 0); Console.WriteLine("x"); }
            else if (MaTurn == 4) { Locate(0, 1); Console.WriteLine("x"); }
            else if (MaTurn == 5) { Locate(1, 1); Console.WriteLine("x"); }
            else if (MaTurn == 6) { Locate(2, 1); Console.WriteLine("x"); }
            else if (MaTurn == 7) { Locate(0, 2); Console.WriteLine("x"); }
            else if (MaTurn == 8) { Locate(1, 2); Console.WriteLine("x"); }
            else { Locate(2, 2); Console.WriteLine("x"); }
        }

        static void HuCell(int HuTurn)
        {
            if (HuTurn == 1) { Locate(0, 0); Console.Write("o"); }
            else if (HuTurn == 2) { Locate(1, 0); Console.WriteLine("o"); }
            else if (HuTurn == 3) { Locate(2, 0); Console.WriteLine("o"); }
            else if (HuTurn == 4) { Locate(0, 1); Console.WriteLine("o"); }
            else if (HuTurn == 5) { Locate(1, 1); Console.WriteLine("o"); }
            else if (HuTurn == 6) { Locate(2, 1); Console.WriteLine("o"); }
            else if (HuTurn == 7) { Locate(0, 2); Console.WriteLine("o"); }
            else if (HuTurn == 8) { Locate(1, 2); Console.WriteLine("o"); }
            else { Locate(2, 2); Console.WriteLine("o"); }
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }
    }
}