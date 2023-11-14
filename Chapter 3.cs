using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project
{
    class Program
    {
        static void Main()
        {

        }

        static void ExerciseTen()
        {
            string strnum;
            do
            {
                Console.Write("Enter a four-digit number: ");
                strnum = Console.ReadLine();
            } while ((strnum.Length) != 4);

            int firstnum = (int)strnum[0] - 48;
            int secondnum = (int)strnum[1] - 48;
            int thirdnum = (int)strnum[2] - 48;
            int fourthnum = (int)strnum[3] - 48;

            Console.WriteLine($"Sum of {firstnum} + {secondnum} + {thirdnum} + {fourthnum}" +
                                      $" = {firstnum + secondnum + thirdnum + fourthnum}");

            Console.WriteLine($"The number in reversed order: {fourthnum}{thirdnum}{secondnum}{firstnum}");

        }

        static void ExerciseEight()
        {
            Console.Write("Enter an x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter a y: ");
            double y = double.Parse(Console.ReadLine());

            if ((x * x + y * y) <= 25d) Console.WriteLine($"{x} and {y} is within circle K(0, 0) with radius = 5");
            else Console.WriteLine($"{x} and {y} is not within circle K");
        }

        static void ExerciseEleven()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            int pos = int.Parse(Console.ReadLine());
            int comparednum = exp(pos);

            if ((num & comparednum) != 0) Console.WriteLine("The bit on position " + pos + " is " + 1);
            else Console.WriteLine("The bit on position " + pos + " is " + 0);
        }

        static void ExerciseFourteen()
        {
            int num, maxcount, totalcount = 0;
            do
            {
                Console.Write("Enter an integer between 2 and 99: ");
                num = int.Parse(Console.ReadLine());
            } while ((num <= 1) || (num >= 100));

            for (int count = 1; count <= (maxcount = num); ++count)
                if ((num % count) == 0) ++totalcount;

            if (totalcount > 2) Console.WriteLine("Not a prime integer");
            else Console.WriteLine("A prime integer");
        }

        static void ExcerciseThirteen()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter the value you want to change to (0/1): ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter the position you want to change the value: ");
            int pos = int.Parse(Console.ReadLine());

            int currpos, comparednum = exp(pos);

            if ((num & comparednum) != 0) currpos = 1;
            else currpos = 0;

            if (currpos !=  v)
            {
                if (v == 1) Console.WriteLine("The number is now changed to: " + (num + comparednum));
                else if(v == 0) Console.WriteLine("The number is now changed to: " + (num - comparednum));
            }
            else Console.WriteLine("The number is now changed to: " + num);
        }

        static int exp(int pos)
        {
            int count, maxcount = pos, res = 1;

            if (pos == 0) return 1;
            else
            {
                for (count = 1; count <= maxcount; ++count)
                    res = 2 * res;
                return res;
            }
        }

        static void ExerciseFour()
        {
            Console.Write("Enter an intger between 0 and 255: ");
            byte num = byte.Parse(Console.ReadLine());

            num <<= 5;
            num >>= 7;

            if (num == 1)
                Console.WriteLine("The third bit is 1");
            else if(num == 0)
                Console.WriteLine("The third bit is 0");
        }

        static void ExerciseThree()
        {
            Console.Write("There's a third digit from right to left that is 7: ");
            string strnum = Console.ReadLine();
            int i = strnum.Length - 3;

            if (strnum.Length >= 3)
            {
                if(strnum[i] == '7')
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
                Console.WriteLine("No");
        }

        static void ExerciseTwo()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            int countMaxOne = num / 5;
            int countMaxTwo = num / 7;
            int countOne = 1, countTwo = 1;
            bool check = false;

            while(countOne <= countMaxOne)
            {
                if((countOne * 5) == num)
                {
                    check = true;
                    break;
                }

                ++countOne;
            }

            if(check == true)
            {
                check = false;
                while (countTwo <= countMaxTwo)
                {
                    if((countTwo * 7) == num)
                    {
                        check = true;
                        Console.WriteLine("It is divisible by 5 and 7");
                        break;
                    }
;
                    ++countTwo;
                }
            }

            if (check == false)
                Console.WriteLine("It is not divisible by 5 and 7");
        }
    }
}