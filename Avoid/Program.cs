using System.Diagnostics;
using System;

namespace opoopopoop
{
    internal class FileName
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

            Console.CursorVisible = false;

            ConsoleKeyInfo temp;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Vector2 playerPos;

            Bullet[] bullet = new Bullet[20];

            for (int i = 0; i < bullet.Length; i++)
            {
                bullet[i].isFired = false;
            }


            playerPos.x = 0;
            playerPos.y = 0;

            watch.Start();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    temp = Console.ReadKey(true);
                    if (temp.Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < bullet.Length; i++)
                        {
                            if (bullet[i].isFired == true)
                            {
                                continue;
                            }
                            else if (bullet[i].isFired == false)
                            {
                                bullet[i].posX = playerPos.x;
                                bullet[i].posX = playerPos.y;
                                bullet[i].isFired = true;
                                break;
                            }
                        }
                    }
                    else if (temp.Key == ConsoleKey.D)
                    {
                        playerPos.x += 2;

                    }
                    else if (temp.Key == ConsoleKey.A)
                    {
                        if (playerPos.x > 0)
                        {
                            playerPos.x -= 2;
                        }
                        else
                        {
                            playerPos.x = 0;
                        }
                    }
                    else if (temp.Key == ConsoleKey.W)
                    {
                        if (playerPos.y > 0)
                        {
                            playerPos.y -= 1;
                        }
                        else
                        {
                            playerPos.y = 0;
                        }
                    }
                    else if (temp.Key == ConsoleKey.S)
                    {
                        playerPos.y += 1;

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

                Console.SetCursorPosition(playerPos.x, playerPos.y);
                Console.WriteLine("◎");

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

