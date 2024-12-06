using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldjlajljasldjflskfjwon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■□□□□□□□□□□□□□□□□□□□□□□□□□□□□■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            ConsoleKeyInfo inputKey;


            // 30
            int consoleX = 1;

            // 30
            int consoleY = 1;

            int hurt = 4;

            Random random = new Random();
            Stopwatch watch = new Stopwatch();
            watch.Start();

            long endScore = 100000000000000000;
            long playerScore = 0;





            watch.Start();
            int aaX = 2;
            int aaY = 1;
            string gunChar = "▶";
            bool isFired = false;


            while (playerScore < endScore)
            {
                //  playerScore = (long)watch.ElapsedMilliseconds;
                // Console.WriteLine(playerScore);
                Console.SetCursorPosition(consoleX * 2, consoleY);
                Console.Write("●");

                if (watch.ElapsedMilliseconds >= 160)
                {
                    watch.Restart();
                    if (Console.KeyAvailable) //키가 눌렸을때만 참
                    {
                        inputKey = Console.ReadKey(true);


                        switch (inputKey.Key)
                        {

                            //  -▶
                            case ConsoleKey.RightArrow:
                                isFired = true;
                                consoleX++;
                                Console.SetCursorPosition((consoleX - 1) * 2, consoleY);
                                Console.Write("□");
                                break;



                            // ◀-
                            case ConsoleKey.LeftArrow:
                                isFired = true;
                                consoleX--;
                                Console.SetCursorPosition((consoleX + 1) * 2, consoleY);
                                Console.Write("□");
                                break;




                            // ▲
                            // ㅣ
                            case ConsoleKey.UpArrow:
                                isFired = true;
                                consoleY--;
                                Console.SetCursorPosition(consoleX * 2, consoleY + 1);
                                Console.Write("□");
                                break;



                            // ㅣ
                            // ▼
                            case ConsoleKey.DownArrow:
                                isFired = true;
                                consoleY++;
                                Console.SetCursorPosition(consoleX * 2, consoleY - 1);
                                Console.Write("□");
                                break;


                        }
                        // 왼쪽 밖으로 못나가게
                        if (consoleX < 1)
                        {
                            consoleX = 1;
                        }

                        // 위쪽 밖으로 못나가게
                        else if (consoleY < 1)
                        {

                            consoleY = 1;
                        }

                        // 오른쪽 밖으로 못나가게
                        else if (consoleX > 28)
                        {
                            consoleX = 28;
                        }

                        // 아래쪽 밖으로 못나가게
                        else if (consoleY > 28)
                        {
                            consoleY = 28;
                        }
                    }

                    if (isFired == true)
                    {
                        Console.SetCursorPosition(aaX, aaY);
                        Console.WriteLine("　");
                        aaX += 2;
                        Console.SetCursorPosition(aaX, aaY);
                        Console.Write(gunChar);
                        if (aaX > 54)
                        {
                            Console.SetCursorPosition(aaX, aaY);
                            Console.Write("  ");
                            break;
                        }

                    }
                }


            }
            while (true)
            {

            }
        }
    }
}