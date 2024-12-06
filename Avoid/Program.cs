using System.Diagnostics;
using System;

namespace Day11
{
    internal class Program
    {
        struct Vector2
        {
            public int x;
            public int y;

        }

        struct Bullet
        {
            public int posX;
            public int posY;
            public bool isFired;
        }



        static void Main(string[] args)
        {
            Console.CursorVisible = false; //커서 안보이게

            ConsoleKeyInfo temp; //키입력 기억할 변수
            Stopwatch watch = new Stopwatch(); //이 한줄 적으면 스탑워치가 만들어진다
            watch.Start(); //스탑워치 시작함

            Vector2 playerPos;

            playerPos.x = 0;
            playerPos.y = 0;

            // 값 초기화
            bool isFired = false;
            int posX = 0;
            int posY = 0;



            while (true)
            {


                //=================입력만!!!=====================
                if (Console.KeyAvailable) //키가 눌렸을때만 참
                {
                    temp = Console.ReadKey(true); //키입력이 담김
                    if (temp.Key == ConsoleKey.Spacebar) //스페이스 바 눌리면 true로 바꾸기
                    {
                        if (isFired == true)
                        {
                            continue;
                        }
                        else
                        {
                            posX = playerPos.x;
                            posY = playerPos.y;
                            isFired = true;
                        }
                    }

                    else if (temp.Key == ConsoleKey.A)
                    {
                        playerPos.x -= 2;
                    }

                    else if (temp.Key == ConsoleKey.D)
                    {
                        playerPos.x += 2;
                    }
                    else if (temp.Key == ConsoleKey.W)
                    {
                        playerPos.y--;
                    }
                    else if (temp.Key == ConsoleKey.S)
                    {
                        playerPos.y++;
                    }
                }





                //===========================================로직 처리
                if (watch.ElapsedMilliseconds >= 2000)
                {

                    if (isFired == true)
                    {
                        posX += 2;
                        if (posX > 100)
                        {
                            isFired = false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                    watch.Restart();
                }
                //==============================================그리는 부분==================

                Console.SetCursorPosition(playerPos.x, playerPos.y);
                Console.Write("◈");

                // foreach (var a in bullets)
                //  {
                Console.SetCursorPosition(posX, posY);
                Console.Write("▶");
                //   }




            }
        }
    }
}