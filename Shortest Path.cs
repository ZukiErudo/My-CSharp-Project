using System;

namespace c__Project_2
{
    internal class Class7
    {
        static int bigPosIndex = 0, count = 0;
        static int[][ , ] arrayOfPosLen;

        static void Main()
        {
            Print("Tong cac diem ban muon chon (a,b,c,d,e,....): ");
            int n = int.Parse(Console.ReadLine());

            arrayOfPosLen = new int[Factorial(n)][,];

            int[] array = new int[n];
            string[] arrayOfLetter = new string[n];
            int letterIndex = 0;

            Print("\n------------------------------\n");

            do
            {
                Print($"{letterIndex + 1}/Nhap mot diem: ");
                arrayOfLetter[letterIndex] = Console.ReadLine();
                ++letterIndex;
            } while (letterIndex < n);

            Print("\n------------------------------\n\n");
            Print("Luu y: Neu ko co chieu dai thi ghi \"none\"\n\n");

            string[][] arrayOfInfo = new string[n][];

            for(int i = 0, j = 1; i < n - 1; ++i, ++j)
            {
                arrayOfInfo[i] = new string[n - 1];

                for(int k = j; k < n; ++k)
                {
                    if (i != 0)
                    {
                        for (int index = 0; index < i; ++index)
                            arrayOfInfo[i][index] = arrayOfInfo[index][i - 1];
                    }

                    Print($"Nhap chieu dai cua doan {arrayOfLetter[i]}{arrayOfLetter[k]}: ");
                    arrayOfInfo[i][k - 1] = Console.ReadLine();
                    Print("\n");
                }
            }

            arrayOfInfo[n - 1] = new string[n - 1];

            for(int i = 0; i < n - 1; ++i)
                arrayOfInfo[n - 1][i] = arrayOfInfo[i][n - 2];

            Print("\n------------------------------\n\n");
            Print("Chon diem bat dau: ");
            string start = Console.ReadLine();

            Print("\nChon diem ket thuc: ");
            string end = Console.ReadLine();

            Print("\n");

            int numStart = 0, numEnd = 0;

            for(int i = 0; i < arrayOfLetter.Length; ++i)
            {
                if(start == arrayOfLetter[i]) numStart = i;

                if (end == arrayOfLetter[i]) numEnd = i;
            }

            Print($"Diem bat dau la {start}\n\n");
            Print($"Diem ket thuc la {end}\n\n"); 
            Print("------------------------------\n\n");

            int lastIndex = --n;
            int[] smallArray = new int[1];

            for (int i = 0; i < array.Length; ++i)
            {
                smallArray[0] = i;
                Subset(smallArray, lastIndex, arrayOfLetter, arrayOfInfo, numStart, numEnd);
            }

            int min = arrayOfPosLen[0][0, 0], m = 0;

            Print("\n------------------------------\n\n");
            Print($"Danh sach chieu dai va duong di tu {start} den {end}: \n\n");

            for(int i = 0; i <= bigPosIndex - 1; ++i)
            {
                Print($"{arrayOfPosLen[i][0, 0]}\n");

                for (int j = 0; j < arrayOfPosLen[i].GetLength(1); ++j)
                    Print($"{arrayOfLetter[arrayOfPosLen[i][1, j]]} ");
                
                Print("\n\n");
            }


            for(int i = 0; i < bigPosIndex - 1; ++i)
            {
                if (min > arrayOfPosLen[i + 1][0, 0])
                {
                    min = arrayOfPosLen[i + 1][0, 0];
                    m = i + 1;
                }
            }

            Print($"Chieu dai ngan nhat tu {start} den {end} la {min}\nduong di la: ");

            for(int i = 0; i < arrayOfPosLen[m].GetLength(1);  ++i)
                Print($"{arrayOfLetter[arrayOfPosLen[m][1, i]]} ");

            Print($"\n\ntotal cases: {count}\n\n");
        }

        static void Subset(int[] array, int lastIndex, string[] arrayOfletter, string[][] arrayOfInfo, int numStart, int numEnd)
        {
            int[] newArray = new int[array.Length + 1];

            for (int index = 0; index < newArray.Length - 1; newArray[index] = array[index], ++index) ;

            for (int i = newArray[newArray.Length - 2] + 1; i <= lastIndex; ++i)
            {
                newArray[newArray.Length - 1] = i;
                int[] oldArray = new int[newArray.Length];

                for (int j = 0; j < oldArray.Length; j++)
                    oldArray[j] = newArray[j];

                int[] swapArray = new int[newArray.Length];

                for (int j = 0; j < swapArray.Length; ++j)
                    swapArray[j] = newArray[newArray.Length - j - 1];

                bool checkIfTheSame = false;

                ////////////////////////////////////////////////////////
                
                while(checkIfTheSame == false)
                {
                    ++count;
                    Print("(");

                    for (int j = 0; j < newArray.Length; ++j)
                    {
                        if (j < newArray.Length - 1) Print($"{arrayOfletter[newArray[j]]}, ");
                        else Print($"{arrayOfletter[newArray[j]]})\n");
                    }

                    ////////////////////////////////////////////////////////

                    int k = 0, totalLength = 0;
                    bool checkIfError = false;

                    while (k < newArray.Length - 1)
                    {
                        if (newArray[k] < newArray[k + 1])
                        {
                            if (arrayOfInfo[newArray[k]][newArray[k + 1] - 1] == "none") 
                            {
                                checkIfError = true; break;
                            }

                            totalLength += int.Parse(arrayOfInfo[newArray[k]][newArray[k + 1] - 1]);
                        }
                        else if (newArray[k] > newArray[k + 1])
                        {
                            if (arrayOfInfo[newArray[k]][newArray[k + 1]] == "none") 
                            {
                                checkIfError = true; break;
                            }

                            totalLength += int.Parse(arrayOfInfo[newArray[k]][newArray[k + 1]]);
                        }

                        ++k;
                    }

                    if (checkIfError == true) Print("Error: ko the tinh toan\n\n\n");
                    else
                    {
                        if (newArray[0] == numStart && newArray[newArray.Length - 1] == numEnd)
                        {
                            Print($"Chieu dai la {totalLength}\n\n\n");

                            arrayOfPosLen[bigPosIndex] = new int[2, newArray.Length];
                            arrayOfPosLen[bigPosIndex][0, 0] = totalLength;

                            for (int col = 0; col < newArray.Length; ++col)
                                arrayOfPosLen[bigPosIndex][1, col] = newArray[col];

                            ++bigPosIndex;
                        }
                        else Print($"Chieu dai la {totalLength}\n\n\n");
                    }

                    newArray = Permutation(newArray);

                    checkIfTheSame = true;

                    for (int j = 0; j < newArray.Length; ++j)
                    {
                        if (newArray[j] != swapArray[j])
                        {
                            checkIfTheSame = false; break;
                        }
                    }

                    ////////////////////////////////////////////////////////

                    if (checkIfTheSame == true)
                    {
                        ++count;
                        Print("(");

                        for (int j = 0; j < newArray.Length; ++j)
                        {
                            if (j < newArray.Length - 1) Print($"{arrayOfletter[newArray[j]]}, ");
                            else Print($"{arrayOfletter[newArray[j]]})\n");
                        }

                        ////////////////////////////////////////////////////////

                        k = 0; totalLength = 0;
                        checkIfError = false;

                        while (k < newArray.Length - 1)
                        {
                            if (newArray[k] > newArray[k + 1])
                            {
                                if (arrayOfInfo[newArray[k]][newArray[k + 1]] == "none")
                                {
                                    checkIfError = true; break;
                                }

                                totalLength += int.Parse(arrayOfInfo[newArray[k]][newArray[k + 1]]);
                            }

                            ++k;
                        }

                        if (checkIfError == true) Print("Error: ko the tinh toan\n\n\n");
                        else
                        {
                            if (newArray[0] == numStart && newArray[newArray.Length - 1] == numEnd)
                            {
                                Print($"Chieu dai la {totalLength}\n\n\n");

                                arrayOfPosLen[bigPosIndex] = new int[2, newArray.Length];
                                arrayOfPosLen[bigPosIndex][0, 0] = totalLength;

                                for (int col = 0; col < newArray.Length; ++col)
                                    arrayOfPosLen[bigPosIndex][1, col] = newArray[col];

                                ++bigPosIndex;
                            }
                            else Print($"Chieu dai la {totalLength}\n\n\n");
                        }
                    }
                }

                newArray = oldArray;

                Subset(newArray, lastIndex, arrayOfletter, arrayOfInfo, numStart, numEnd);
            }
        }

        static int[] Permutation(int[] array)
        {
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

            return array;
        }

        static long Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}
