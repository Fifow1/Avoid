
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{
    internal class BulletManager
    {
        public Bullet[] bullets;
        BulletBefore[] bulletBefore = new BulletBefore[30];



        public BulletManager()
        {
            // 0 ~ 29 = 30개
            bullets = new Bullet[30];
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet();
                bullets[i].IsFired = false;
            }

        }


        // true, false로 총알 최대 범위 체크
        //public bool BulletMaxRange(int bulletY)
        //{
        //    if (bulletY > 29)
        //    {

        //        return bulletMaxRange = true;
        //    }
        //    else
        //    {
        //        return bulletMaxRange = false;
        //    }
        //}

        // 랜덤 값을 받아서 그 값과 일치하는 총알 배열 true
        public void BulletRandomXY(Random rand)
        {
            // 1 ~ 29
            int rndDicection = rand.Next(0, 4);
            int rndBulletX = rand.Next(0, 30);
            for (int i = 1; i < bullets.Length; i++)
            {
                if (rndBulletX == i && bullets[i].IsFired == false)
                {
                    bullets[i].IsFired = true;
                    if (rndDicection == 0)
                    {
                        bullets[i]._direction = BulletDirection.up;
                        bullets[i].BulletX = i * 2;
                        bullets[i].BulletY = 0;
                    }
                    else if (rndDicection == 1)
                    {
                        bullets[i]._direction = BulletDirection.down;
                        bullets[i].BulletX = i * 2;
                        bullets[i].BulletY = 30;
                    }
                    else if (rndDicection == 2)
                    {
                        bullets[i]._direction = BulletDirection.left;
                        bullets[i].BulletX = 0;
                        bullets[i].BulletY = i;
                    }
                    else if (rndDicection == 3)
                    {
                        bullets[i]._direction = BulletDirection.right;
                        bullets[i].BulletX = 60;
                        bullets[i].BulletY = i;

                    }
                }
            }
        }


        // 랜덤 값을 받아서 그 값과 일치하는 총알 배열 true
        public void BulletRandomXY()
        {
            // 1 ~ 29
            int rndBulletX = new Random().Next(1, 30);
            for (int i = 1; i < bullets.Length; i++)
            {
                if (rndBulletX == i)
                {
                    bullets[i].IsFired = true;
                }

            }
        }
        public void BulletXY()
        {
            for (int i = 1; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == false)
                {
                    continue;
                }
                else if (bullets[i].IsFired == true)
                {
                    // x,y의 이전 좌표 저장
                    bulletBefore[i]._x = bullets[i].BulletX;
                    bulletBefore[i]._y = bullets[i].BulletY;
                    if (bullets[i]._direction == BulletDirection.up)
                    {
                        bullets[i].BulletY += 1;


                        // 프로퍼티를 이용해 1,2,3,4, 조건 처리가능한지
                        // if문을 밖에 하나 만들어서 1< x < 58 , 1< y <29 범위 밖에 나가면 false 처리하기

                        // 1
                        if (bullets[i].BulletY > 29)
                        {
                            bullets[i].IsFired = false;

                        }
                        //
                    }
                    else if (bullets[i]._direction == BulletDirection.down)
                    {
                        bullets[i].BulletY -= 1;

                        // 2
                        if (bullets[i].BulletY < 1)
                        {
                            bullets[i].IsFired = false;

                        }
                        //
                    }
                    else if (bullets[i]._direction == BulletDirection.left)
                    {
                        bullets[i].BulletX += 2;

                        // 3
                        if (bullets[i].BulletX > 58)
                        {
                            bullets[i].IsFired = false;

                        }
                        // 

                    }
                    else if (bullets[i]._direction == BulletDirection.right)
                    {
                        bullets[i].BulletX -= 2;

                        // 4
                        if (bullets[i].BulletX < 2)
                        {
                            bullets[i].IsFired = false;

                        }
                        //

                    }
                }
                else if (bullets[i].IsFired == false)
                {
                    continue;
                }

            }
        }

        // 총알 출력
        public void BulletPrint()
        {
            for (int i = 1; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                    if (bullets[i]._direction == BulletDirection.up)
                    {
                        if (bullets[i].BulletY > 1)
                        {
                            Console.WriteLine("▼");
                            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                            Console.WriteLine("　");
                        }

                    }
                    else if (bullets[i]._direction == BulletDirection.down)
                    {
                        if (bullets[i].BulletY < 29)
                        {
                            Console.WriteLine("▲");
                            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                            Console.WriteLine("　");
                        }
                    }
                    else if (bullets[i]._direction == BulletDirection.left)
                    {
                        if (bullets[i].BulletX > 2)
                        {
                            Console.WriteLine("▶");
                            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                            Console.WriteLine("　");
                        }
                    }
                    else if (bullets[i]._direction == BulletDirection.right)
                    {
                        if (bullets[i].BulletX < 58)
                        {
                            Console.WriteLine("◀");
                            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                            Console.WriteLine("　");

                        }
                    }

                    //if ((2 < bullets[i].BulletX && bullets[i].BulletX < 58) || (1 < bullets[i].BulletY && bullets[i].BulletY  < 29))
                    //{
                    //    Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                    //    Console.WriteLine("　");
                    //}

                    //if (2 < bullets[i].BulletX && bullets[i].BulletX < 58 && )
                    //{

                    //}

                    // 총알 발사 범위 초과될때 마지막 모습 지우기
                    //if (bullets[i].BulletY == 29 || bullets[i].BulletY == 1)
                    //{
                    //    Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                    //    Console.WriteLine("　");

                    //}

                }
            }
        }
    }
}
