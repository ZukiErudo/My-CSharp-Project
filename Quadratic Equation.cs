using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Program2
    {
        static void Main()
        {
            bool checkIfDouble;
            double a, b, c;

            do
            {
                Locate(0, 0); EmptyLine();
                Locate(0, 0); Console.Write("a = ");
                checkIfDouble = double.TryParse(Console.ReadLine(), out a);
            } while (checkIfDouble == false);

            do
            {
                Locate(0, 1); EmptyLine();
                Locate(0, 1); Console.Write("b = ");
                checkIfDouble = double.TryParse(Console.ReadLine(), out b);
            } while (checkIfDouble == false);

            do
            {
                Locate(0, 2); EmptyLine();
                Locate(0, 2); Console.Write("c = ");
                checkIfDouble = double.TryParse(Console.ReadLine(), out c);
            } while (checkIfDouble == false);

            double delta = (b * b) - (4 * a * c); // delta = b^2 - 4ac
            double sqrtOfDelta, x1, x2; // sqare root of delta two roots x1, x2

            if (a == 0)
            {
                if (b == 0) Console.WriteLine("This function has no real roots");
                else Console.WriteLine("The function {0}x + {1} = 0 has x = {2}", b, c, -c / b);
            }
            else
            {
                if (delta == 0) Console.WriteLine("The function {0}x^2 + {1}x + {2} = 0 has x = {3}", a, b, c, -b / (2d * a));
                else if (delta > 0)
                {
                    sqrtOfDelta = Math.Sqrt(delta);
                    x1 = (-b + sqrtOfDelta) / (2d * a);
                    x2 = (-b - sqrtOfDelta) / (2d * a);

                    Console.WriteLine("The function {0}x^2 + {1}x + {2} = 0 has x1 = {3} and x2 = {4}", a, b, c, x1, x2);
                }
                else Console.WriteLine("The fucntion {0}x^2 + {1}x + {2} = 0 has no real roots", a, b, c);
            }
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }

        static void EmptyLine()
        {
            string line = "";
            for (int i = 1; i <= 100; ++i, line += " ") ;

            Console.WriteLine(line);
        }
    }
}
