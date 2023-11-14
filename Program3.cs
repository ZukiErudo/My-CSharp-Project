using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*Thay nho phong to cua so terminal de co trai nghiem tot nhat nha thay*/

namespace c__Project_2
{
    internal class Class2
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            string ans = "y";

            while (ans == "y")
            {
                CLS();
                int num = Menu();
                CLS();
                Console.ForegroundColor = ConsoleColor.Black;

                if (num == 1)      ExerciseOne();
                else if (num == 2) ExerciseTwo();
                else if (num == 3) ExerciseThree();
                else if (num == 4) ExerciseSixteen();
                else if (num == 5) ExerciseTwentyOne();
                else if (num == 6) MultiplicationTable();
                else if (num == 7) SubsetConsistsTwoElements();
                else if (num == 8) Set();

                do
                {
                    Print("Do you want to continue (y/n): ");
                    ans = Console.ReadLine();
                } while (!(ans == "y" || ans == "n"));
            }

            Print("\n\n\t\tGoodbye!\n");
        }

        /////////////////////////////////////////////////

        static int Menu()
        {
            WinSize(125, 25);
            Console.ForegroundColor = ConsoleColor.Black;
            Locate(40, 22); Print("Press WASD to move and press K to choose");
            Console.ForegroundColor = ConsoleColor.White;

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

                if(Console.KeyAvailable == true)
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
                        if (col == 5) col = 4;
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
            Locate(13, 4);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 1");
            Locate(4, 5);    Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Tinh S1 S2 S3 S4 S5 S6");
            Locate(44, 4);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 2");
            Locate(40, 5);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Tinh S2 S5 S6");
            Locate(75, 4);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 3");
            Locate(71, 5);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("So nguyen to");
            Locate(106, 4);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 16");
            Locate(102, 5);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Day Fibonacci");
            Locate(12, 15);  Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Bai 21");
            Locate(7, 16);   Console.ForegroundColor = ConsoleColor.DarkGreen; Print("Tam giac Pascal");
            Locate(40, 15);  Console.ForegroundColor = ConsoleColor.Magenta;   Print("Bang Cuu Chuong");
            Locate(73, 15);  Console.ForegroundColor = ConsoleColor.Red;       Print("Tap 2 con");
            Locate(104, 15); Console.ForegroundColor = ConsoleColor.DarkRed;   Print("Tat ca Tap");
            Locate(103, 16); Console.ForegroundColor = ConsoleColor.DarkRed;   Print("BAI KHO NHAT");
                             Console.ForegroundColor = ConsoleColor.White;
        }

        static int ChosenOne(int col, int row)
        {
            int num = 0;
            if (col == 1 && row == 1) num = 1;
            if (col == 2 && row == 1) num = 2;
            if (col == 3 && row == 1) num = 3;
            if (col == 4 && row == 1) num = 4;
            if (col == 1 && row == 2) num = 5;
            if (col == 2 && row == 2) num = 6;
            if (col == 3 && row == 2) num = 7;
            if (col == 4 && row == 2) num = 8;
            
            return num;
        }

        //////////////////////////////////////////////////

        static void ButtonLocation(int col, int row)
        {
            if (col == 1 && row == 1) Button(0, 0);
            if (col == 2 && row == 1) Button(31, 0);
            if (col == 3 && row == 1) Button(62, 0);
            if (col == 4 && row == 1) Button(93, 0);
            if (col == 1 && row == 2) Button(0, 10);
            if (col == 2 && row == 2) Button(31, 10);
            if (col == 3 && row == 2) Button(62, 10);
            if (col == 4 && row == 2) Button(93, 10);
        }

        static void Button(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
            Console.ForegroundColor = ConsoleColor.White;
        }

        //////////////////////////////////////////////////

        static void ClearButtonLocation(int col, int row)
        {
            if (col == 1 && row == 1) ClearButton(0, 0);
            if (col == 2 && row == 1) ClearButton(31, 0);
            if (col == 3 && row == 1) ClearButton(62, 0);
            if (col == 4 && row == 1) ClearButton(93, 0);
            if (col == 1 && row == 2) ClearButton(0, 10);
            if (col == 2 && row == 2) ClearButton(31, 10);
            if (col == 3 && row == 2) ClearButton(62, 10);
            if (col == 4 && row == 2) ClearButton(93, 10);
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
            Console.ForegroundColor = ConsoleColor.Black;
            Cell(0, 0);  Cell(31, 0);  Cell(62, 0);  Cell(93, 0);
            Cell(0, 10); Cell(31, 10); Cell(62, 10); Cell(93, 10);
            Console.ForegroundColor = ConsoleColor.White;
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
        
        //////////////////////////////////////////////////
        
        static void SubsetConsistsTwoElements()
        {
            WinSize(50, 61);
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter an integer: ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (checkIfInt == false); 

            int[] array = new int[++n];

            for (int i = 0; i < array.Length; array[i] = i, ++i) ;

            for(int i = 0; i < array.Length - 1; ++i)
                for (int j = i + 1; j < array.Length; ++j)
                    Print($"({i}, {j})\n");
        }

        //////////////////////////////////////////////////

        static void MultiplicationTable()
        {
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter an integer: ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (checkIfInt == false);

            for (int i = 1; i <= n; ++i, Print("\n"))
                for (int j = 1; j <= 10; Print($"{i}*{j}={i * j}\t"), ++j) ;    
        }

        //////////////////////////////////////////////////

        static void ExerciseTwentyOne()
        {
            WinSize(201, 61);
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter n for Height of the Pascal Triangle: ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);   
            } while (checkIfInt == false);

            for(int row = 1; row <= n; PascalTriangleRowN(row), Print("\n"), ++row);
        }

        static void PascalTriangleRowN(int n)
        {
            for (int num = 0; num <= n; Print($"{N_Combination(n, num)}\t"), ++num) ;
        }

        static long N_Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        //////////////////////////////////////////////////

        static void ExerciseSixteen()
        {
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter an integer n (n >= 2): ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (!(n >= 2 && checkIfInt == true));

            Print($"a{n} = {Fibonacci(n)}\n");
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //////////////////////////////////////////////////

        static void ExerciseThree()
        {
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print($"Enter an integer n (n > 0): ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (checkIfInt == false);

            if (n > 0) Print($"{n} is a prime number: {PrimeCheck(n)}\n");
            else Print($"{n} is not a prime\n");
        }

        static bool PrimeCheck(int n)
        {
            bool check = false;
            int num = 2, count = 0;

            while(num <= n)
            {
                if (n % num == 0) ++count;
                ++num;
            }

            if(count == 1) check = true;
            return check;
        }
        
        //////////////////////////////////////////////////

        static void ExerciseTwo()
        {
            double a;
            bool checkIfDouble;

            do
            {
                CLS();
                Print("Enter a (a > 0 and a < 1): ");
                checkIfDouble = double.TryParse(Console.ReadLine(), out a);
            } while (!(a > 0 && a < 1 && checkIfDouble == true));
            
            Print($"S2 = {NewS2(a)}\n");
            Print($"S5 = {NewS5(a)}\n");
            Print($"S6 = {NewS6(a)}\n");
        }

        /////////////////////

        static double NewS2(double a)
        {
            double sum = 0.0;
            int soHangThuN = 1;

            for (double num = 1; ; sum += 1d / num, ++num, ++soHangThuN) 
            {
                if (a > (1d / soHangThuN)) break;
            }

            return sum;
        }

        /////////////////////

        static double NewS5(double a)
        {
            double sum = 0;
            int soHangThuN = 1;

            for (int num = 1; ; sum += 1d / Factorial(num), ++num, ++soHangThuN) 
            {
                if (a > (1d / soHangThuN)) break;
            }

            return sum;
        }

        /////////////////////

        static double NewS6(double a)
        {
            double sum = 0.0;
            int soHangThuN = 1;

            for (int num = 1; ; sum += 1d / N_multiply_NplusOne(num), ++num, ++soHangThuN) 
            {
                if (a > (1d / soHangThuN)) break;
            }

            return sum;
        }

        //////////////////////////////////////////////////

        static void ExerciseOne()
        {
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter n = ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (checkIfInt == false);

            Print($"S1 = {S1(n)}\n");
            Print($"S2 = {S2(n)}\n");
            Print($"S3 = {S3(n)}\n");
            Print($"S4 = {S4(n)}\n");
            Print($"S5 = {S5(n)}\n");
            Print($"S6 = {S6(n)}\n");
        }

        /////////////////////

        static int S1(int n)
        {
            int sum = 0;
            for (int num = 1; num <= n; sum += num, ++num) ; 
            return sum;
        }

        /////////////////////

        static double S2(int n)
        {
            double sum = 0.0;
            for (double num = 1; num <= n; sum += 1d / num, ++num) ;
            return sum;
        }

        /////////////////////

        static int S3(int n)
        {
            int sum = 0;
            for (int num = 1; num <= n; sum += num * 10 + num, ++num) ;
            return sum;
        }

        /////////////////////

        static long S4(int n)
        {
            long sum = 1;
            for (int num = 1; num <= n; sum *= num, ++num) ;
            return sum;
        }

        /////////////////////

        static double S5(int n)
        {
            double sum = 0;
            for (int num = 1; num <= n; sum += 1d / Factorial(num), ++num) ;
            return sum;
        }

        static long Factorial(int n)
        {
            if(n == 0) return 1;
            return n * Factorial(n - 1);
        }

        /////////////////////

        static double S6(int n)
        {
            double sum = 0.0;
            for (int num = 1; num <= n; sum += 1d / N_multiply_NplusOne(num), ++num) ;
            return sum;
        }

        static int N_multiply_NplusOne(int n)
        {
            return n * (n + 1);
        }

        //////////////////////////////////////////////////

        static void Set()
        {
            WinSize(50, 61);
            int n;
            bool checkIfInt;

            do
            {
                CLS();
                Print("Enter n = ");
                checkIfInt = int.TryParse(Console.ReadLine(), out n);
            } while (checkIfInt == false);

            int[] array = new int[++n];
            int lastIndex = --n;
            Print("(Empty)\n");

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i; Print($"({array[i]})\n");
            }

            int[] smallArray = new int[1];

            for(int i = 0; i < array.Length; ++i)
            {
                smallArray[0] = i;
                Subset(smallArray, lastIndex);
            }
        }

        static void Subset(int[] array, int lastIndex)
        {
            int[] newArray = new int[array.Length + 1];

            for (int index = 0; index < newArray.Length - 1; newArray[index] = array[index], ++index) ;

            for(int i = newArray[newArray.Length - 2] + 1; i <= lastIndex; ++i)
            {
                newArray[newArray.Length - 1] = i;
                Print("(");

                for(int j = 0; j < newArray.Length; ++j)
                {
                    if(j < newArray.Length - 1) Print($"{newArray[j]}, ");
                    else Print($"{newArray[j]})\n");
                }

                Subset(newArray, lastIndex);
            }
        }

        //////////////////////////////////////////////////

        static char Getch()
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

        static void WinSize(int x, int y)
        {
            Console.SetWindowSize(x, y);
        }
    }
}
/*Written by Zuki Erudo*/