using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Program1
    {
        static void Main()
        {
            bool check;
            int num;
            string answer = "y";

            do
            {
                do
                {
                    CLS(); // Console.Clear();
                    Console.Write("Chon bai tap (1/2/3) de xem: ");
                    check = int.TryParse(Console.ReadLine(), out num);
                } while (!(check == true && num >= 1 && num <= 3));

                CLS();

                if (num == 1) Ex1();
                else if (num == 2) Ex2();
                else if (num == 3) Ex3();

                do
                {
                    Locate(0, 3); EmptyLine();
                    Locate(0, 3); Console.Write("Do you want to continue (y/n): ");
                    answer = Console.ReadLine();
                } while (answer != "y" && answer != "n");

                if (answer == "y")
                {
                    Wait();
                    CLS();
                }
                
            } while (answer == "y");

            Console.ForegroundColor = ConsoleColor.Red;
            Locate(30, 5); Console.WriteLine("Goobye!");
            Console.ResetColor();
        }

        static void Ex3()
        {
            bool checkinputchar;
            char ch;
            string str, upperCh;

            do
            {
                CLS();
                Console.Write("Nhap vao mot chu ky tu viet thuong (a-z): ");
                str = Console.ReadLine();
            } while (str.Length == 0);

            checkinputchar = char.TryParse(str, out ch);

            if (checkinputchar == true && ((int)ch >= 97 && (int)ch <= 122))
            {
                upperCh = (ch.ToString()).ToUpper();
                Console.WriteLine("Ky tu viet in hoa tuong ung la: {0}", upperCh);
            }
            else Console.WriteLine("Khong phai ky tu chu biet thuong");
        }

        static void Ex2()
        {
            int num;
            char asciinum;
            bool checknum;

            do
            {
                CLS();
                Console.Write("Nhap vao mot gia tri so: ");
                checknum = int.TryParse(Console.ReadLine(), out num);
            } while (checknum == false);

            asciinum = (char)num;

            if (num >= 48 && num <= 57) Console.WriteLine("La ma cua ky tu so {0}", asciinum);
            else if (num >= 65 && num <= 90) Console.WriteLine("La ma cua ky tu in hoa {0}", asciinum);
            else if (num >= 97 && num <= 122) Console.WriteLine("La ma cua ky tu thuong {0}", asciinum);
            else Console.WriteLine("La ma cua cac ky tu dac biet khac");
        }

        static void Ex1()
        {
            string name;
            bool checkingSex, sex; 

            do
            {
                CLS();
                Console.Write("Nhap Ho Ten: ");
                name = Console.ReadLine();
            } while (name.Length == 0);

            do
            {
                Locate(0, 1); EmptyLine();
                Locate(0, 1); Console.Write("Nhap Gioi Tinh (true(nam)/false(nu)): ");
                checkingSex = bool.TryParse(Console.ReadLine(), out sex);
            } while (checkingSex == false);

            if (sex == true) Console.WriteLine("Chao anh {0}", name);
            else Console.WriteLine("Chao chi {0}", name);
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

        static void Wait()
        {
            Console.WriteLine("Please wait for the program to continue....");
            Thread.Sleep(3000);
        }

        static void CLS()
        {
            Console.Clear();
        }
    }
}