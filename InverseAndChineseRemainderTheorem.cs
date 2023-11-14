using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class6
    {
        static void Main()
        {
            //ChineseRemainderTheorem();
            //FindInverse(7, 4);
        }

        static void ChineseRemainderTheorem()
        {
            Print("Co bao nhieu phuong trinh x ban muon tinh: ");
            int n = int.Parse(Console.ReadLine());

            int[] arrayOf_a = new int[n];
            int[] arrayOf_m = new int[n];
            int k = 1, ai = 0, mi = 0;

            do
            {
                Print($"\nx mod m{k} = a{k}\n");

                Print($"\nEnter m{k} for the above function: ");
                arrayOf_m[mi] = int.Parse(Console.ReadLine());

                Print($"Enter a{k} for the above function: ");
                arrayOf_a[ai] = int.Parse(Console.ReadLine());

                ++mi; ++ai; ++k;

                Print("------------------------------\n");
            } while (k <= n);

            Print("\nThe value in arrayOf_m is: ");
            foreach (int value in arrayOf_m)
            {
                Print($"{value} ");
            }

            Print("\nThe value in arrayOf_a is: ");
            foreach(int value in arrayOf_a)
            {
                Print($"{value} ");
            }

            int m = 1;
            string mValue = "";
            foreach(int value in arrayOf_m)
            {
                mValue += " * " + value; 
                m *= value;
            }

            Print($"\n\nm = {mValue.Substring(2)} = {m}\n\n");

            long a = 0;
            for(int i = 1, M, y; i <= n; ++i)
            {
                Print("------------------------------\n\n");

                M = m / arrayOf_m[i - 1];

                y = FindInverse(M, arrayOf_m[i - 1]);

                if (y < 0) y += arrayOf_m[i - 1];

                a += arrayOf_a[i - 1] * M * y;

                Print($"M{i} = {M}, inverse of {M} modulo {arrayOf_m[i - 1]} = {y} and a = {a}\n\n");
            }

            Print($"x = {a} mod {m} = {a % m}\n\n");
        }

        static int FindInverse(int n, int m)
        {
            Print($"Find inverse of {n} modulo {m}\n\n");

            int b = n > m ? n : m;
            int a = n < m ? n : m;
            int q, r;

            int SjMinus2 = 1, SjMinus1 = 0, TjMinus2 = 0, TjMinus1 = 1;
            int Sj = 0, Tj = 0;
            int j = 2, inverseOfn = 0, inverseOfm = 0;

            while (b % a != 0)
            {
                q = b / a; 
                r = b % a;

                Sj = SjMinus2 - q * SjMinus1; 
                Tj = TjMinus2 - q * TjMinus1; 

                Print($"S{j} = S{j - 2} - q{j - 1} * S{j - 1} = {SjMinus2} - {q} * {SjMinus1} = {Sj}\n");
                Print($"T{j} = T{j - 2} - q{j - 1} * T{j - 1} = {TjMinus2} - {q} * {TjMinus1} = {Tj}\n\n");

                SjMinus2 = SjMinus1; 
                TjMinus2 = TjMinus1;

                SjMinus1 = Sj; 
                TjMinus1 = Tj;

                b = a; a = r; ++j;
            }

            if (Sj * n + Tj * m == 1)
            {
                inverseOfn = Sj;
                inverseOfm = Tj;
            }
            else if (Tj * n + Sj * m == 1)
            {
                inverseOfn = Tj;
                inverseOfm = Sj;
            }

            if (a != 1) Print($"There is no inverse of {n} modulo {m} because GCD({n}, {m}) = {a}\n");
            else
            {
                Print($"GCD({n}, {m}) = 1\n");
                Print($"We have ({inverseOfn}) * {n} + ({inverseOfm}) * {m} = 1\n");
                Print($"The inverse of {n} modulo {m} = {inverseOfn}\n\n");
            }

            return inverseOfn;
        }

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}