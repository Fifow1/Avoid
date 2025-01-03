﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        // 랜덤 값을 받아서 그 값과 일치하는 총알 배열 true
        public void BulletRandomXY(Random rand,int wallCount)
        {
            // random 좌,우,상,하
            int rndDicection = rand.Next(0, wallCount);

            // ramdom bullet x좌표
            int rndBulletX1 = rand.Next(0, 30);
            int rndBulletX2 = rand.Next(0, 30);
            for (int i = 1; i < bullets.Length; i++)
            {
                if ((rndBulletX1 == i || rndBulletX2 == i) && bullets[i].IsFired == false)
                {
                    bullets[i].IsFired = true;
                    // 발사 된 총알 방향과 방향에 따른 초기값 정해주기
                    if (rndDicection == 0)
                    {
                        bullets[i].Direction = BulletDirection.up;
                        bullets[i].BulletX = i * 2;
                        bullets[i].BulletY = 0;
                    }
                    else if (rndDicection == 1)
                    {
                        bullets[i].Direction = BulletDirection.down;
                        bullets[i].BulletX = i * 2;
                        bullets[i].BulletY = 30;
                    }
                    else if (rndDicection == 2)
                    {
                        bullets[i].Direction = BulletDirection.left;
                        bullets[i].BulletX = 0;
                        bullets[i].BulletY = i;
                    }
                    else if (rndDicection == 3)
                    {
                        bullets[i].Direction = BulletDirection.right;
                        bullets[i].BulletX = 60;
                        bullets[i].BulletY = i;

                    }
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

                    // 사정거리
                    bullets[i]._count += 1;
                    if (bullets[i]._count > 30)
                    {
                        bullets[i].IsFired = false;
                        bullets[i]._count = 0;
                    }
                    //

                    else if (bullets[i].Direction == BulletDirection.up)
                    {
                        bullets[i].BulletY += 1;
                    }
                    else if (bullets[i].Direction == BulletDirection.down)
                    {
                        bullets[i].BulletY -= 1;
                    }
                    else if (bullets[i].Direction == BulletDirection.left)
                    {
                        bullets[i].BulletX += 2;
                    }
                    else if (bullets[i].Direction == BulletDirection.right)
                    {
                        bullets[i].BulletX -= 2;
                    }
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
                    if (bullets[i]._count == 30)
                    {
                        Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                        Console.WriteLine("　");
                    }
                    if (bullets[i]._count > 1 && bullets[i]._count < 30)
                    {
                        Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                        if (bullets[i].Direction == BulletDirection.up)
                        {
                            Console.WriteLine("▼");
                        }
                        else if (bullets[i].Direction == BulletDirection.down)
                        {
                            Console.WriteLine("▲");
                        }
                        else if (bullets[i].Direction == BulletDirection.left)
                        {
                            Console.WriteLine("▶");
                        }
                        else if (bullets[i].Direction == BulletDirection.right)
                        {
                            Console.WriteLine("◀");
                        }
                        Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                        Console.WriteLine("　");
                    }
                }
            }
        }
    }
}
