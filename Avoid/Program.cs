using System.Diagnostics;
using System;
using System.Data.SqlTypes;

namespace opoopopoop
{
    // 크기를 많이 차지하지 않을 것 같아 클래스가 아닌 구조체로 만듦
    struct PlayerBefore
    {
        public int _x;
        public int _y;
    }
    struct BulletBefore
    {
        public int _x;
        public int _y;
    }

    class Player
    {
        int _heart;
        int _x;
        int _y;
        public PlayerBefore playerBefore;

        public int PlayerX { get { return _x; } set { _x = value; } }
        public int PlayerY { get { return _y; } set { _y = value; } }
        public int PlayerHp { get { return _heart; } set { _heart = value; } }

        public Player()
        {
            _x = 26;
            _y = 16;
            _heart = 3;
            // 초값 안넣으면 0,0 에 빈공간 출력되서 넣음
            playerBefore._x = _x;
            playerBefore._y = _y;
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine("●");
        }


        public bool GameOverCheck()
        {
            return _heart == 0;
        }

        public void CountHeart(Bullet[] bullets)
        {
            for (int i = 1; i < bullets.Length; i++) 
            {
                if (_x == bullets[i].BulletX && _y== bullets[i].BulletY)
                {
                    _heart -= 1;
                }

            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo keyInput = Console.ReadKey(true);
            playerBefore._x = _x;
            playerBefore._y = _y;

            //  -- ▶
            if (keyInput.Key == ConsoleKey.D)
            {
                if (_x < 58)
                {
                    _x += 2;
                }
                else
                {
                    _x = 58;
                }
            }

            //  ◀--
            else if (keyInput.Key == ConsoleKey.A)
            {
                if (_x > 2)
                {
                    _x -= 2;
                }
                else
                {
                    _x = 2;
                }

            }

            //  ▲
            //  ㅣ

            else if (keyInput.Key == ConsoleKey.W)
            {
                if (_y > 1)
                {
                    _y--;
                }
                else
                {
                    _y = 1;
                }
            }

            //  ㅣ
            //  ▼
            else if (keyInput.Key == ConsoleKey.S)
            {
                if (_y < 27)
                {
                    _y++;
                }
                else
                {
                    _y = 27;
                }
            }



        }


    }

    class Bullet
    {
        int _x;
        int _y;
        bool _isFired;

        public Bullet()
        {
            _isFired = false;
        }
        public int BulletX { get { return _x; } set { _x = value; } }
        public int BulletY { get { return _y; } set { _y = value; } }
        public bool IsFired { get { return _isFired; } set { _isFired = value; } }

    }

    
    class BulletManager
    {
        public Bullet[] bullets;
        BulletBefore[] bulletBefore = new BulletBefore[30];


        bool bulletMaxRange;


        public BulletManager()
        {
            // 0 ~ 29 = 30개
            bullets = new Bullet[30];
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet();
                bullets[i].BulletX = i * 2;
                bullets[i].BulletY = 0;
                bullets[i].IsFired = false;
            }

        }


        // true, false로 총알 최대 범위 체크
        public bool BulletMaxRange(int bulletY)
        {
            if (bulletY > 27)
            {

                return bulletMaxRange = true;
            } else
            {
                return bulletMaxRange = false;
            }
        }

        // 랜덤 값을 받아서 그 값과 일치하는 총알 배열 true
        public void BulletRandomXY()
        {
            // 1 ~ 29
            int rndBulletX = new Random().Next(1,30);
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
                if (bullets[i].IsFired == true)
                {
                    bulletBefore[i]._x = bullets[i].BulletX;
                    bulletBefore[i]._y = bullets[i].BulletY;
                    bullets[i].BulletY += 1;

                    // 사거리 초과일때
                    if (BulletMaxRange(bullets[i].BulletY) == true)
                    {
                        bullets[i].IsFired = false;

                        // 사거리 초과 되면 다시 발사할 수 있게 좌표 초기화
                        bullets[i].BulletX= i * 2; ;
                        bullets[i].BulletY = 0;

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
                    // 총알이 맵 위에 출력되는걸 방지
                    if (bullets[i].BulletY > 1)
                    {
                        Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                        Console.WriteLine("ㅁ");
                        Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
                        Console.WriteLine(" ");

                    }
                    if (bullets[i].BulletY == 27)
                    {
                        // 총알 발사 범위 초과될때 마지막 모습 지우기
                        Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                        Console.WriteLine(" ");

                    }
                }
            }
        }


    }

    internal class FileName
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            //Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅣ　　　　　　　　　　　　　　　　　　　　　　　　　　　　　ㅣ");
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

            // 콘솔에서 커서 안보이게
            Console.CursorVisible = false;

            Stopwatch watch = new Stopwatch();

            Player player = new Player();
            Bullet bullet = new Bullet();
            BulletManager bulletManager = new BulletManager();


            int count = 0;

            int a = bullet.BulletY + count;
            watch.Start();
            while (true)
            {
                //if (player.GameOverCheck())
                //{
                //    Console.SetCursorPosition(0,20);
                //    Console.ReadKey(true);
                //    break;
                //}
                Console.SetCursorPosition(70, 0);
                Console.WriteLine("플레이어 체력" + " ♥ " + player.PlayerHp);
                if (Console.KeyAvailable)
                {
                    player.MovePlayer();
                }
                if (watch.ElapsedMilliseconds > 200)
                {
                    watch.Restart();
                    // 총알 좌표 업데이트 함수
                    // 안에 20초마다 방향 바꾸기
                    bulletManager.BulletRandomXY();
                    bulletManager.BulletXY();
                    player.CountHeart(bulletManager.bullets);

                }


                bulletManager.BulletPrint();
                Console.SetCursorPosition(player.playerBefore._x, player.playerBefore._y);
                Console.WriteLine(" ");
                Console.SetCursorPosition(player.PlayerX, player.PlayerY);
                Console.WriteLine("ㅇ");
            }

        }

    }
}