using System;

namespace c__Project_2
{
    internal class Class1
    {
        static void Main()
        {
            int[] array = { 0, 1, 2, 3 };
            int[] swapArray = new int[array.Length];

            for (int i = 0; i < swapArray.Length; ++i)
                swapArray[i] = array[array.Length - i - 1];

            Permutation(array, swapArray);
        }

        static int[] Permutation(int[] array, int[] swapArray)
        {
            foreach (int value in array) Print($"{value} ");
            Print("\n\n");

            bool checkIfTheSame = true;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] != swapArray[i])
                {
                    checkIfTheSame = false; break;
                }
            }

            if (checkIfTheSame == true) return swapArray;

            bool swapAtEnd = false;
            int posIndex = -1;

            for (int i = 0; i < array.Length - 1; ++i)
            {
                if (array[i] < array[i + 1])
                {
                    posIndex = i;
                    if (posIndex == array.Length - 2) swapAtEnd = true;
                }
            }

            if (swapAtEnd == true)
            {
                int m = array[array.Length - 2];
                array[array.Length - 2] = array[array.Length - 1];
                array[array.Length - 1] = m;
            }
            else
            {
                if (posIndex > -1)
                {
                    /*Find after posIndex which integer is the least integer that is greater than posIndex integer*/
                    int size = 0;

                    for (int i = posIndex + 1; i < array.Length; ++i)
                        if (array[i] > array[posIndex]) ++size;

                    int[] subArray = new int[size];

                    for (int i = posIndex + 1, j = 0; i < array.Length; ++i)
                    {
                        if (array[i] > array[posIndex])
                        {
                            subArray[j] = array[i]; ++j;
                        }
                    }

                    int minOfSubArray = subArray[0];

                    for (int i = 1; i < subArray.Length; ++i)
                    {
                        if (subArray.Length == 1) break;

                        if (minOfSubArray > subArray[i]) minOfSubArray = subArray[i];
                    }

                    int numAtPosIndex = array[posIndex];
                    array[posIndex] = minOfSubArray;
                    int[] subScript = new int[array.Length - (posIndex + 1)];

                    /*Put the numAtPosIndex in the subScript*/

                    for (int i = posIndex + 1, j = 0; j < subScript.Length; ++j, ++i)
                    {
                        if (array[i] == minOfSubArray) subScript[j] = numAtPosIndex;
                        else subScript[j] = array[i];
                    }

                    /*Now we have to sort the subArray in increasing order*/

                    Array.Sort(subScript);

                    /*merge the array and the subArray*/

                    for (int i = posIndex + 1, j = 0; i < array.Length; ++i, ++j)
                        array[i] = subScript[j];
                }
            }

            return Permutation(array, swapArray);
        }

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}
