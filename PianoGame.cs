using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class2
    {
        static void Main()
        {
            Console.SetWindowSize(51, 41); Wall(); //

            int x = 18, oldx, objCol = 2;
            int hitObjY = 1, oldHitObjY;
            long delay = 15000000;
            //int score = 0;
            int time = 0;

            Random rand = new Random();
            int col = rand.Next(1, 4);

            while (true)
            {
                for (long wait = 0; wait < delay; ++wait) ;

                //if(score == 20)
                //{
                //    score = 0;
                //    delay -= 10000000;
                //}

                if(hitObjY == 34 || (col == objCol && hitObjY >= 27))
                {
                    if(col == objCol && hitObjY >= 27) //Console.Beep(523, 50);
                    {
                        ++time;
                        if (time == 27) time = 1;
                        Piano(time);
                    }

                    EmptyMoveFiveRow(col, hitObjY);
                    col = rand.Next(1, 4); hitObjY = 2; //++score;
                }

                ++hitObjY; oldHitObjY = hitObjY;

                Move(col, hitObjY);
                EmptyMove(col, oldHitObjY);
                
                oldx = x;
                Obj(x);

                if (Console.KeyAvailable == true)
                {
                    char ch = getch();

                    if (ch == 'a')
                    {
                        --objCol; x -= 15;

                        if (objCol < 1)
                        {
                            objCol = 1; x = 3;
                        }

                        Empty(oldx);
                    }
                    else if (ch == 'd')
                    {
                        ++objCol; x += 15;

                        if (objCol > 3)
                        {
                            objCol = 3; x = 33;
                        }

                        Empty(oldx);
                    }
                    else if(ch == 'k') break;
                }

            }

            Locate(10, 20);
        }

        static void Move(int col, int y)
        {
            if (col == 1) HitObj(6, y);
            else if(col == 2) HitObj(21, y);
            else if(col == 3) HitObj(36, y);
        }

        static void EmptyMove(int col, int y)
        {
            if (col == 1) EmptyLine(6, y);
            else if (col == 2) EmptyLine(21, y);
            else if (col == 3) EmptyLine(36, y);
        }

        static void EmptyMoveFiveRow(int col, int row)
        {
            EmptyMove(col, row + 1);
            EmptyMove(col, row + 2);
            EmptyMove(col, row + 3);
            EmptyMove(col, row + 4);
            EmptyMove(col, row + 5);
        }

        static  void EmptyLine(int x, int y)
        {
            Locate(x, y); Print("      ");
        }

        static void HitObj(int x, int y)
        {
            int countY = y;
            int countX = x, oldx = x;

            for(; y <= (countY + 5); ++y)
            {
                for(; x <= (countX + 5); ++x)
                {
                    Locate(x, y); Print(".");
                }
                x = oldx;
            }
        }

        static void Obj(int x)
        {
            int count = x, oldx = x;

            for(int y = 33; y <= 39; ++y)
            {
                for(; x <= (count + 11); ++x)
                {
                    Locate(x, y); Print("*");
                }
                x = oldx;
            }
        }

        static void Empty(int x)
        {
            int count = x, oldx = x;

            for (int y = 33; y <= 39; ++y)
            {
                for (; x <= (count + 11); ++x)
                {
                   Locate(x, y); Print(" ");
                }
                x = oldx;
            }
        }

        static char getch()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            return key.KeyChar;
        }

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }

        static void Wall()
        {
            for (int y = 1; y <= 40; ++y)
            {
                Locate(1, y); Print("|");
            }

            for (int y = 1; y <= 40; ++y)
            {
                Locate(46, y); Print("|");
            }

            for (int x = 1; x <= 46; ++x)
            {
                Locate(x, 1); Print("_");
            }

            for (int x = 1; x <= 46; ++x)
            {
                Locate(x, 40); Print("-");
            }

            for (int y = 2; y <= 39; ++y)
            {
                Locate(16, y); Print("|");
            }

            for (int y = 2; y <= 39; ++y)
            {
                Locate(31, y); Print("|");
            }
        }

        static void CLS()
        {
            Console.Clear();
        }

        static void Print(string text)
        {
            Console.Write(text);
        }



        ////////////////////////////////////////////////////////////////////////////////////////

        static int GetPianoKey(string note)
        {
            int key = -1;
            switch (note[0])
            {
                case 'A': key = 1; break;
                case 'B': key = 3; break;
                case 'C': key = 4; break;
                case 'D': key = 6; break;
                case 'E': key = 8; break;
                case 'F': key = 9; break;
                case 'G': key = 11; break;
            }
            if (note.Length == 2)
            {
                return key + 12 * (note[1] - '0');
            }
            if (note.Length == 3)
            {
                return key + 12 * (note[2] - '0') + (note[1] == 'b' ? -1 : 1);
            }
            throw new ApplicationException("Wrong note.");
        }

        static int GetNoteFrequency(string note)
        {
            return (int)(Math.Pow(1.05946309436, GetPianoKey(note) - 49) * 440);
        }

        static int GetTickDuration(int tempo)
        {
            return 60000 / tempo;
        }

        private static void Piano(int time)
        {
            int duration = GetTickDuration(120); // 120 bpm. duration for quarter note

            if (time == 1) Console.Beep(GetNoteFrequency("A3"), duration / 5); // eighth note ==> duration/2
            if (time == 2) Console.Beep(GetNoteFrequency("B3"), duration / 5);
            if (time == 3) Console.Beep(GetNoteFrequency("C3"), duration / 5);
            if (time == 4) Console.Beep(GetNoteFrequency("D3"), duration / 5);

            if (time == 5) Console.Beep(GetNoteFrequency("E3"), duration / 5);
            if (time == 6) Console.Beep(GetNoteFrequency("C3"), duration / 5);
            if (time == 7) Console.Beep(GetNoteFrequency("E3"), duration / 5);
            //Task.Delay(duration / 2).Wait(); //  eighth rest ==> duration/2

            if (time == 8) Console.Beep(GetNoteFrequency("D#3"), duration / 5);
            if (time == 9) Console.Beep(GetNoteFrequency("B3"), duration / 5);
            if (time == 10) Console.Beep(GetNoteFrequency("D#3"), duration / 5);
            //Task.Delay(duration / 2).Wait();

            if (time == 11) Console.Beep(GetNoteFrequency("D3"), duration / 5);
            if (time == 12) Console.Beep(GetNoteFrequency("Bb3"), duration / 5);
            if (time == 13) Console.Beep(GetNoteFrequency("D3"), duration / 5);
            //Task.Delay(duration / 2).Wait();

            if (time == 14) Console.Beep(GetNoteFrequency("A3"), duration / 5);
            if (time == 15) Console.Beep(GetNoteFrequency("B3"), duration / 5);
            if (time == 16) Console.Beep(GetNoteFrequency("C3"), duration / 5);
            if (time == 17) Console.Beep(GetNoteFrequency("D3"), duration / 5);

            if (time == 18) Console.Beep(GetNoteFrequency("E3"), duration / 5);
            if (time == 19) Console.Beep(GetNoteFrequency("C3"), duration / 5);
            if (time == 20) Console.Beep(GetNoteFrequency("E3"), duration / 5);
            if (time == 21) Console.Beep(GetNoteFrequency("A4"), duration / 5);

            if (time == 22) Console.Beep(GetNoteFrequency("G3"), duration / 5);
            if (time == 23) Console.Beep(GetNoteFrequency("E3"), duration / 5);
            if (time == 24) Console.Beep(GetNoteFrequency("C3"), duration / 5);
            if (time == 25) Console.Beep(GetNoteFrequency("E3"), duration / 5);

            if (time == 26) Console.Beep(GetNoteFrequency("G3"), 200); // half note ==> duration*2
        }
    }
}