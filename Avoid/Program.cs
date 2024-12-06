using System.Diagnostics;
using System;

namespace opoopopoop
{
    internal class FileName
    {
        struct PlayerVector
        {
            public int x;
            public int y;

        }

        struct PlayerVectorBefore
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

            Console.CursorVisible = false;

            ConsoleKeyInfo inputKey;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            // 플레이어 구조체
            PlayerVector playerVec;
            PlayerVectorBefore playerVecBe;

            Bullet[] bullet = new Bullet[20];

            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i].isFired = false;
            }


            playerVec.x = 17;
            playerVec.y = 17;
            playerVecBe.x = 17;
            playerVecBe.y = 17;

            watch.Start();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    inputKey = Console.ReadKey(true);
                    if (inputKey.Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < bullet.Length; i++)
                        {
                            if (bullet[i].isFired == true)
                            {
                                continue;
                            }
                            else if (bullet[i].isFired == false)
                            {
                                bullet[i].posX = playerVec.x;
                                bullet[i].posY = playerVec.y;
                                bullet[i].isFired = true;
                                break;
                            }
                        }
                    }
                    else if (inputKey.Key == ConsoleKey.D)
                    {

                        playerVecBe.x = playerVec.x;
                        playerVecBe.y = playerVec.y;
                        playerVec.x += 2;

                    }
                    else if (inputKey.Key == ConsoleKey.A)
                    {
                        playerVecBe.x = playerVec.x;
                        playerVecBe.y = playerVec.y;
                        if (playerVec.x > 2)
                        {

                            playerVec.x -= 2;
                        }
                        else
                        {
                            playerVec.x = 0;
                        }
                    }
                    else if (inputKey.Key == ConsoleKey.W)
                    {
                        if (playerVec.y > 0)
                        {
                            playerVecBe.x = playerVec.x;
                            playerVecBe.y = playerVec.y;
                            playerVec.y -= 1;
                        }
                        else
                        {
                            playerVec.y = 0;
                        }
                    }
                    else if (inputKey.Key == ConsoleKey.S)
                    {
                        playerVecBe.x = playerVec.x;
                        playerVecBe.y = playerVec.y;
                        playerVec.y += 1;

                    }
                }


                if (watch.ElapsedMilliseconds > 160)
                {
                    watch.Restart();
                    for (int i = 0; i < bullet.Length; i++)
                    {
                        if (bullet[i].isFired == true)
                        {
                            bullet[i].posX += 2;
                            if (bullet[i].posX > 100)
                            {
                                bullet[i].isFired = false;
                            }
                        }
                        else if (bullet[i].isFired == false)
                        {
                            continue;
                        }
                    }
                }

                Console.SetCursorPosition(playerVec.x, playerVec.y);
                Console.WriteLine("◎");
                Console.SetCursorPosition(playerVecBe.x, playerVecBe.y);
                Console.WriteLine("ㅁ");

                foreach (Bullet a in bullet)
                {
                    if (a.isFired == true)
                    {
                        Console.SetCursorPosition(a.posX, a.posY);
                        Console.WriteLine("★");
                    }
                }

            }


        }



    }



}

