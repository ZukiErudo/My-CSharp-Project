using System;

namespace c__Project_2
{
    internal class Program5
    {
        static void Main()
        {
            //ExOne();

            //ExTwo();

            //ExThree();

            //ExFour();

            //ExFive();   

            //ExSix();

            //ExSeven();

            //ExEight();

            //ExNine();   

            //ExTen();

            //ExEleven();
        }

        //////////////////////////////////////

        static void ExEleven()
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

            for (int i = 0; i < weightScale.Length; ++i)
            {
                if (bitArray[i] == 1) Print($"- {weightScale[i]}\n");
            }
        }

        static int[] BinaryArray(int n)
        {
            int[] binary = new int[9];
            int q = n, a, i = 8;

            while (q != 0)
            {
                a = q % 2; q = q / 2;
                binary[i] = a; --i;
            }

            return binary;
        }

        //////////////////////////////////////

        static void ExTen()
        {
            int N = NumberOfElements();
            Print("\nNote: All the elements in the array must be a positive integer!\n");
            int[] array = InputArray(N);
            int n, m, count = 0;

            do
            {
                Print("\nNote: n < m!\n");

                do
                {
                    Print("Enter a positive integer for n: ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0);

                do
                {
                    Print("Enter a positive integer for m: ");
                    m = int.Parse(Console.ReadLine());
                } while (m <= 0);

                Print("\n");
            } while (n >= m);

            for(int i = 0; i < N; ++i)
            {
                if (array[i] >= n && array[i] <= m)
                {
                    ++count;
                    Print($"The integer which is in [{n}, {m}] is {array[i]} at index {i}\n");
                }
            }

            Print("\n");
        }

        //////////////////////////////////////

        static void ExNine()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);
            int len = array.Length / 2;
            bool check = true;

            Print("\n");

            for(int i = 0, j = n - 1; i < len; ++i, --j)
            {
                if (array[i] != array[j])
                {
                    Print($"{array[i]} != {array[j]}\n");
                    check = false; break;
                }

                Print($"{array[i]} = {array[j]}\n");
            }

            if (check == true) Print("\nThis array is symetric\n\n");
            else Print("\nThis array is not symetric\n\n");
        }

        //////////////////////////////////////

        static void ExEight()
        {
            int[][] month = new int[12][];

            for (int i = 0; i < 12; month[i] = new int[1], ++i) ;

            for(int i = 0; i < 12; ++i)
            {
                if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11) month[i][0] = 31;
                else if (i == 3 || i == 5 || i == 8 || i == 10) month[i][0] = 30;
                else month[1][0] = 28;
            }

            int num;
            do
            {
                Print("Enter the month (1-12) you want to know the number of days: ");
                num = int.Parse(Console.ReadLine());
            } while (!(num >= 1 && num <= 12));

            Print($"\nThe number of days in month {num} is {month[num - 1][0]}\n");
        }

        //////////////////////////////////////

        static void ExSeven()
        {
            Print($"Enter n for the first n numbers of the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Print("\n");

            for (int i = 0; i < n; array[i] = Fibonacci(i), ++i) ;

            foreach (int value in array) Print($"{value} ");

            Print("\n");
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //////////////////////////////////////

        static void ExSix()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);
            int sumOfNegative = 0, sumOfPositive = 0, countNegative = 0, countPositive = 0;

            Print("\n");

            for(int i = 0; i < n; ++i)
            {
                if (array[i] > 0)
                {
                    sumOfPositive += array[i];
                    ++countPositive;
                }
                else if (array[i] < 0)
                {
                    sumOfNegative += array[i];
                    ++countNegative;
                }
            }

            Print($"The sum of positive integers = {sumOfPositive}\n");
            Print($"The number of positive integers are {countPositive}\n\n");
            Print($"The sum of negative integers = {sumOfNegative}\n");
            Print($"The number of negative integers are {countNegative}\n\n");
        }

        //////////////////////////////////////

        static void ExFive()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);

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

            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                min = (arrayOne[i] < arrayTwo[j]) ? arrayOne[i] : arrayTwo[j];
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
                else
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

        //////////////////////////////////////

        static void ExFour()
        {
            Print("Enter n for the power of the polynomial function: ");
            int n = int.Parse(Console.ReadLine());
            double[] arrayOfCoefficientsAn = new double[n + 1];
            int count = n;
            double sum = 0d;
            
            Print("\n");

            do
            {
                Print($"Enter the value for the coefficient a{count}: ");
                arrayOfCoefficientsAn[n - count] = double.Parse(Console.ReadLine());
                --count;
            } while (count >= 0);

            Print("\nEnter x for calculation of the fucntion: ");
            double x = int.Parse(Console.ReadLine());
            Print("\n");

            for (int i = 0; i < arrayOfCoefficientsAn.Length; ++i)
            {
                sum += arrayOfCoefficientsAn[i] * Math.Pow(x, n - i);
                Print($"sum = {sum}\n");
            }

            Print($"\nTotal sum = {sum}\n\n");
        }

        //////////////////////////////////////

        static void ExThree()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);

            Print("Enter the integer you want to find in array: ");
            int userInput = int.Parse(Console.ReadLine());
            bool check = false;

            Print($"\n");

            for(int i = 0; i < n; ++i)
            {
                if(userInput == array[i])
                {
                    check = true;
                    Print($"{userInput} is at index {i} of the array\n");
                }
            }

            if (check == false) Print($"Cannot find {userInput} at any index in the array\n\n");
        }

        //////////////////////////////////////

        static void ExTwo()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);

            Print("\nEnter the integer you want to find in the array: ");
            int userInput = int.Parse(Console.ReadLine());
            bool check = false;

            for(int i = 0; i < n; ++i)
            {
                if (array[i] == userInput)
                {
                    check = true; break;
                }
            }

            if(check == true) Print($"{userInput} belongs to the array\n");
            else Print($"{userInput} does not belong to the array\n");
        }

        //////////////////////////////////////

        static void ExOne()
        {
            int n = NumberOfElements();
            int[] array = InputArray(n);
            int min = array[0], max = array[0];

            for(int i = 1; i < n - 1; ++i)
            {
                if(min > array[i]) min = array[i];
                if (max < array[i]) max = array[i];
            }

            Print($"\nFinal max = {max} and final min = {min}\n\n");
        }

        //////////////////////////////////////

        static int NumberOfElements()
        {
            Print("Enter n for the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        static int[] InputArray(int n)
        {
            int[] array = new int[n];
            int index = 0;

            Print("\n");

            do
            {
                Print($"Enter an integer for index {index}: ");
                array[index] = int.Parse(Console.ReadLine());
                ++index;
            } while (index < n);

            Print("\n");
            return array;
        }

        //////////////////////////////////////

        static void Print(string text)
        {
            Console.Write(text);
        }
    }
}