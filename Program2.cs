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
            //ZeroTo999();
            EuclidGCD();
        }

        static void EuclidGCD()
        {
            int inputOne, inputTwo;
            bool checkInputOne, checkInputTwo;

            do
            {
                CLS();
                Print("Enter a first number: ");
                checkInputOne = int.TryParse(Console.ReadLine(), out inputOne);
            } while (checkInputOne == false);

            do
            {
                Locate(0, 1); EmptyLine();
                Locate(0, 1); Print("Enter a second number: ");
                checkInputTwo = int.TryParse(Console.ReadLine(), out inputTwo);
            } while (checkInputTwo == false);

            int b = inputOne > inputTwo ? inputOne : inputTwo;
            int a = inputOne < inputTwo ? inputOne : inputTwo;

            Print($"gcd({b}, {a}) = {GCD(b, a)}\n");
        }

        static int GCD(int b, int a)
        {
            if (a == 0) return b;
            if (b % a != 0)
            {
                int c = b - a * (b / a);
                return GCD(a, c);
            }
            else return a;
        }

        static void ZeroTo999()
        {
            NumOutPut(NumInput()); Print("\n");
        }

        static string NumInput()
        {
            bool checkIfNum;
            int num;

            do
            {
                CLS();
                Print("Enter an integer (0-999): ");
                checkIfNum = int.TryParse(Console.ReadLine(), out num);
            } while (!(checkIfNum == true && num >= 0 && num <= 999));

            return num.ToString();
        }

        static void NumOutPut(string strnum)
        {
            if (strnum.Length == 1) UnitRow(strnum);
            else if (strnum.Length == 2) Dozens(strnum);
            else Hundreds(strnum);
        }

        static void UnitRow(string strnum)
        {
            NumberInWord(strnum[0]);
        }

        static void Dozens(string strnum)
        {
            if (strnum[0] == '1')
            {
                if (strnum[1] == '0') Muoi();
                else if (strnum[1] == '5') MuoiLam();
                else
                {
                    Muoi(); NumberInWord(strnum[1]);
                }
            }
            else
            {
                if (strnum[1] == '0')
                {
                    NumberInWord(strnum[0]); Muoi();
                }
                else if (strnum[1] == '5')
                {
                    NumberInWord(strnum[0]); MuoiLam();
                }
                else
                {
                    NumberInWord(strnum[0]); Muoi(); NumberInWord(strnum[1]);
                }
            }
        }

        static void Hundreds(string strnum)
        {
            if (strnum[1] == '0')
            {
                if (strnum[2] == '0')
                {
                    NumberInWord(strnum[0]); Tram();
                }
                else
                {
                    NumberInWord(strnum[0]); TramLinh(); NumberInWord(strnum[2]);
                }
            }
            else
            {
                NumberInWord(strnum[0]); Tram(); Dozens(strnum.Substring(1,2));
            }
        }

        static void NumberInWord(char strnum)
        {
            switch (strnum) 
            {
                case '0': Print("khong"); break; 
                case '1': Print("mot");   break;
                case '2': Print("hai");   break;
                case '3': Print("ba");    break;
                case '4': Print("bon");   break;
                case '5': Print("nam");   break;
                case '6': Print("sau");   break;
                case '7': Print("bay");   break;
                case '8': Print("tam");   break;
                case '9': Print("chin");  break;
            }
        }

        static void Muoi()
        {
            Print(" muoi ");
        }

        static void MuoiLam()
        {
            Print(" muoi lam");
        }

        static void Tram()
        {
            Print(" tram ");
        }

        static void TramLinh()
        {
            Print(" tram linh ");
        }

        static void Print(string text)
        {
            Console.Write(text);
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }

        static void EmptyLine()
        {
            string line = "";
            for (int i = 1; i <= 100; ++i, line += " ") ;
            Print(line + "\n");
        }

        static void CLS()
        {
            Console.Clear();
        }
    }
}