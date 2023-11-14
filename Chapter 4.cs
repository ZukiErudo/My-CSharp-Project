using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Chapter4
    {
        static void Main()
        { 

        }

        static void ExerciseEleven()
        {
            ulong a = 0, b = 1, c, count = 1;
            while (count++ <= 100)
            {
                c = a + b; Console.WriteLine($"{a} + {b} = {c}");
                a = b; b = c;
            }
        }

        static void Ex1()
        {
            int row = 1, col = 0, oldrow, oldcol, n, m, count, num; 

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            m = (2 * num) + 1; n = m - 2;

            while (n >= 1)
            {
                string line = "";
                oldrow = row; oldcol = col;

                for (count = 1; count <= n; ++count)
                    line = line + ".";

                for (count = 1; count <= m; ++count, ++row)
                {
                    Locate(col, row); Console.Write("*" + line + "*");
                }

                row = oldrow; col = oldcol;
                ++row; ++col;
                m -= 2; n -= 2;
            }

            Locate(col, row); Console.Write("*");
            Locate(1, row + 12);
        }

        static void Ex2()
        {
            int row = 0, col = 0, count, maxCount = 19, bigCount, bigmaxCount = 19,
                oldRow, oldCol, oldMaxCount, oldBigmaxCount, num = 9;

            while (!(row == 9 && col == 9))
            {
                oldBigmaxCount = bigmaxCount; oldMaxCount = maxCount;
                oldRow = row; oldCol = col;

                for (bigCount = 1; bigCount <= bigmaxCount; ++bigCount, ++row)
                {
                    for (count = 1; count <= maxCount; ++col, ++count)
                    {
                        Locate(col, row); Console.Write(num);
                    }

                    col = oldCol;
                }

                bigmaxCount = oldBigmaxCount; maxCount = oldMaxCount;
                row = oldRow; col = oldCol;

                bigmaxCount -= 2; maxCount -= 2;
                ++row; ++col; --num;
            }

            Locate(col, row); Console.Write(0);
            Locate(0, 20);
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }

        static void ExerciseEight()
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter e = ");
            int e = int.Parse(Console.ReadLine());

            int firstcompare = (a > b ? a : b);
            int secondcompare = (firstcompare > c ? firstcompare : c);
            int thirdcompare = (secondcompare > d ? secondcompare : d);
            int finalcompare = (thirdcompare > e ? thirdcompare : e);

            Console.WriteLine("The greatest number is " + finalcompare);
        }
    }
}