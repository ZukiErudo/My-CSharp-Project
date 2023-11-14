using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class1
    {
        static void Main()
        {
            int[] arrayOfNum = new int[10];
            int number, index = 0, count = 1;
            bool checkIfNum;

            do
            {
                Console.Write("Enter an integer: ");
                checkIfNum = int.TryParse(Console.ReadLine(), out number);

                if(checkIfNum == true)
                {
                    arrayOfNum[index] = number;
                    ++index;
                }
            } while (count++ < arrayOfNum.Length);

            int len = arrayOfNum.Length - 1;
            int a, b, i, j;

            for(; len > 0; --len)
            {
                for(i = 0, j = 1; j <= len; ++i, ++j)
                {
                    a = arrayOfNum[i];
                    b = arrayOfNum[j];

                    if(a > b)
                    {
                        arrayOfNum[i] = b;
                        arrayOfNum[j] = a;
                    }
                }
            }

            foreach(int num in arrayOfNum)
            {
                Console.Write(num + " ");
            }

        }
    }
}
