using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class3
    {
        static void Main()
        {
            int[] array = { 8, 25, 46, 6, 9, 74, 12, 44, 55, 30};

            array = mergesort(array);

            foreach (int index in array)
                Print($"{index} ");

            Print("\n");
        }

        static int[] mergesort(int[] array)
        {
            if (array.Length > 1)
            {
                int m = array.Length / 2;
                int[] arrayOne = new int[m];
                int[] arrayTwo = new int[array.Length - m];

                for (int i = 0; i < arrayOne.Length; arrayOne[i] = array[i], ++i) ;

                for (int i = 0, j = m; i < arrayTwo.Length; arrayTwo[i] = array[j], ++i, ++j) ;

                array = merge(mergesort(arrayOne), mergesort(arrayTwo));
            }

            return array;
        }

        static int[] merge(int[] arrayOne, int[] arrayTwo)
        {
            int i = 0, j = 0;
            int[] newArray = new int[arrayOne.Length + arrayTwo.Length];
            int m = 0, min, k, p;

            while(i < arrayOne.Length && j < arrayTwo.Length)
            {
                min = ( arrayOne[i] < arrayTwo[j] ) ? arrayOne[i] : arrayTwo[j];
                newArray[m] = min;

                if (arrayOne[i] < arrayTwo[j])
                {
                    ++i;
                    if (i == arrayOne.Length)
                    {
                        for (k = newArray.Length - 1, p = arrayTwo.Length - 1; p > j - 1; --p, --k)
                            newArray[k] = arrayTwo[p];
                    }
                }
                else if (arrayOne[i] > arrayTwo[j])
                {
                    ++j;
                    if (j == arrayTwo.Length)
                    {
                        for (k = newArray.Length - 1, p = arrayOne.Length - 1; p > i - 1; --p, --k)
                            newArray[k] = arrayOne[p];
                    }
                }

                ++m;
            }

            return newArray;
        }

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}