using System.Diagnostics;
using System;
using System.Data.SqlTypes;

namespace opoopopoop
{
    struct PlayerBefore
    {
        public int _x;
        public int _y;
    }
    class Player
    {
        int _hp;
        int _x;
        int _y;
        public PlayerBefore playerBefore;

        public int PlayerX { get { return _x; } set { _x = value; } }
        public int PlayerY { get { return _y; } set { _y = value; } }
        public int PlayerHp { get { return _hp; } set { _hp = value; } }

        public Player()
        {
            playerBefore._x = 1;
            playerBefore._y = 1;
            _x = 26;
            _y = 16;
            _hp = 3;
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine("●");
        }


        public void MovePlayer()
        {
            ConsoleKeyInfo keyInput = Console.ReadKey(true);
            playerBefore._x = _x;
            playerBefore._y = _y;

            //  -- ▶
            if (keyInput.Key == ConsoleKey.D)
            {
                _x += 2;
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
                _y++;
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
            _x = 6;
            _y = 6;
            _isFired = false;
        }
        public int BulletX { get { return _x; } set { _x = value; } }
        public int BulletY { get { return _y; } set { _y = value; } }
        public bool IsFired { get { return _isFired; } set { _isFired = value; } }

    }

    class BulletManager
    {
        Bullet[] bullets;
        Random rnd;


        public BulletManager()
        {
            bullets = new Bullet[10];
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet();
                bullets[i].BulletX = i * 2;
                bullets[i].BulletY = 1;
                bullets[i].IsFired = false;
            }

        }

        // 랜덤 값을 받아서 그 값과 일치하는 총알 배열 true
        public void BulletRandom()
        {
            int a = new Random().Next(1, bullets.Length);
            for (int i = 0; i < bullets.Length; i++)
            {
                if (1 == i)
                {
                    bullets[i].IsFired = true;
                }

            }
        }
        public void BulletRandomXY()
        {
            int a = new Random().Next(1, bullets.Length);
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    bullets[i].BulletY += 1;
                    if (bullets[i].BulletY > 20)
                    {
                        bullets[i].IsFired = false;
                    }
                }
                else if (bullets[i].IsFired == false)
                {
                    continue;
                }

            }
        }

        public void BulletPrint()
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].IsFired == true)
                {
                    Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
                    Console.WriteLine("★");
                }
            }
        }

    }

    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            // 콘솔에서 커서 안보이게
            Console.CursorVisible = false;

            Stopwatch watch = new Stopwatch();

            Player player = new Player();
            Bullet bullet = new Bullet();
            BulletManager bulletManager = new BulletManager();


            int count = 0;

            int a = bullet.BulletY + count;
            watch.Start();
            while (player.PlayerHp > 0)
            {
                Console.SetCursorPosition(70, 0);
                Console.WriteLine("플레이어 체력" + " ♥ " + player.PlayerHp);
                if (Console.KeyAvailable)
                {
                    player.MovePlayer();
                }
                if (watch.ElapsedMilliseconds > 300)
                {
                    // watch.Restart();
                    // 총알 좌표 업데이트 함수
                    // 안에 20초마다 방향 바꾸기
                    bulletManager.BulletRandom();
                    bulletManager.BulletRandomXY();
                }


                bulletManager.BulletPrint();
                Console.SetCursorPosition(player.playerBefore._x, player.playerBefore._y);
                Console.WriteLine("　");
                Console.SetCursorPosition(player.PlayerX, player.PlayerY);
                Console.WriteLine("●");
            }

        }

    }
}