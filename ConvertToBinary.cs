using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class5
    {
        static void Main()
        {
            int n;
            bool check;
            do
            {
                Console.Clear();
                Print("Enter the wieght M (M < 512g): ");
                check = int.TryParse(Console.ReadLine(), out n);
            } while (!(check == true && n < 512));

            int[] bitArray = BinaryArray(n);
            int[] weightScale = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };

            Print("\nThe scales used are: \n");

            for(int i = 0; i < weightScale.Length; ++i)
            {
                if (bitArray[i] == 1)
                    Print($"- {weightScale[i]}\n");
            }
        }

        static int[] BinaryArray(int n)
        {
            int[] binary = new int[9];
            int q = n, a, i = 8;

            while(q != 0)
            {
                a = q % 2;
                q = q / 2;

                binary[i] = a; --i;
            }

            return binary;
        }

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}