using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main()
        {
            string ch, option;
            
            do
            {
                do      //Choose which exercise 1 or 2
                {
                    Console.Write("Chon bai tap (1/2): ");
                    option = Console.ReadLine();
                    Console.Clear();       //Clear all
                } while (option != "1" && option != "2");    //Continue to choose in the input is not 1 or 2

                if (option == "1")   //execute the function which represents the exercise 1 if user chooses 1
                    Exercise1();
                else if (option == "2")   //execute the function which represents the exercise 2 user chooses 2
                    Exercise2();

                do      //ask if user wants to continue?
                {
                    Console.Write("Do you want to continue (y/n): ");
                    ch = Console.ReadLine();
                } while (ch != "y" && ch != "n");   //Continue to ask the user to choose if the input is not "y" or "n"

                if (ch == "y")   //If user chooses to continue
                {
                    Wait();      //Let the user wait for 3 seconds
                    Console.Clear();  //Clear all
                }

            } while (ch != "n");      //Stop the program if user chooses "n"

            Locate(30,18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you and Goodbye!\n\n");
        }

        static void Exercise1()  //bai tap 1
        {
            Console.Write("BANG CUU CHUONG\n");

            Line_and_Num(); //draw the rows and numbers

            for (int i = 1; i <= 5; ++i)  //Calculate
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i + ":");
                Console.ForegroundColor = ConsoleColor.White;

                for (int j = 1; j <= 10; ++j)
                    Console.Write("\t|" + (i * j));
                
                Console.WriteLine("");

                if (i != 5)
                    Drawing_line("-");
                else
                    Drawing_line("=");
            }
        }

        static void Line_and_Num()
        {
            Drawing_line("=");
            Line_of_num();
            Drawing_line("=");
        }

        static void Drawing_line(string s)
        {
            for (int i = 0; i <= 87; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(s);
            }

            Console.WriteLine("");
        }

        static void Line_of_num()
        {
            for (int i = 1; i <= 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t|" + i);
            }

            Console.WriteLine("");
        }

        static void Exercise2()
        {
            for (int i = 0; i <= 30; ++i)
                Console.Write("-");
            
            Console.WriteLine("\n");

            Console.WriteLine("Hoa don tien dien");
            Console.Write("Khach hang : ");
            Console.ReadLine();

            int old_amount, new_amount;
            bool check_result;

            do
            {
                Locate(0, 4); Console.Write("                              ");
                Locate(0, 4); Console.Write("Chi so cu : ");

                check_result = int.TryParse(Console.ReadLine(), out old_amount);

            } while ((check_result == false) || old_amount < 0);

            do
            {
                Locate(0, 5); Console.Write("                              ");
                Locate(0, 5); Console.Write("Chi so moi : ");

                check_result = int.TryParse(Console.ReadLine(), out new_amount);

            } while ((check_result == false) || new_amount < 0);

            Console.WriteLine("Tieu thu : " + (new_amount - old_amount));
            Console.WriteLine("Tien dien : " + (new_amount - old_amount)*3000);
            Console.WriteLine("Yeu cau tiet kiem dien");

            Console.WriteLine("");

            for (int i = 0; i <= 30; ++i)
                Console.Write("-");
            
            Console.WriteLine("");
        }

        static void Wait()
        {
            Console.WriteLine("Please wait for the program to continue....");
            Thread.Sleep(3000);
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }
    }
}
/*The end*/
/*Written by Erik Vathan*/