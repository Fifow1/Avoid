using System.Diagnostics;
using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

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

    // 총알의 방향 - bool형식 보다 enum형식이 편리 할 것 같아 사용
    enum BulletDirection
    {
        up, down, left, right
    }

    class Player
    {
        int _heart;
        int _x;
        int _y;

        PlayerBefore playerBefore;


        public int PlayerX { get { return _x; } set { _x = value; } }
        public int PlayerY { get { return _y; } set { _y = value; } }
        public int PlayerHp { get { return _heart; } set { _heart = value; } }

        public Player()
        {
            _x = 26;
            _y = 16;
            _heart = 3;
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
                if (_x == bullets[i].BulletX && _y == bullets[i].BulletY) 
                { 
                    _heart -= 1;
                }

            }
        }

        public void PlayerStatus(Stopwatch watch2)
        {
            Console.SetCursorPosition(70, 2);
            Console.WriteLine("플레이어 체력" + " ♥ " + _heart);
            Console.SetCursorPosition(70, 4);
            Console.WriteLine("버틴 시간 :" + watch2.ElapsedMilliseconds / 1000);
        }
        public void PlayerPrint()
        {
            Console.SetCursorPosition(playerBefore._x, playerBefore._y);
            Console.WriteLine("　");
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine("●");
        }

        public void PlayerMove()
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
                if (_y < 29)
                {
                    _y++;
                }
                else
                {
                    _y = 29;
                }
            }
        }
    }

    class Bullet
    {
        int _x;
        int _y;
        bool _isFired;

        // BulletManager에서 사용됨
        // 건드려도 되는지 안되는지
        // -------------- public을 사용할지 프로퍼티 사용할지 (프로퍼티 사용 기준)
        public BulletDirection _direction;


        public Bullet()
        {
            _isFired = false;
            _direction = BulletDirection.up;
        }

        public int BulletX { get { return _x; } set { _x = value; } }
        public int BulletY { get { return _y; } set { _y = value; } }
        public bool IsFired { get { return _isFired; } set { _isFired = value; } }

    }


    
    class BulletManager
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

    internal class FileName
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("게임시작");

            //}



            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            Console.SetWindowSize(100, 40);

            // 콘솔에서 커서 안보이게
            Console.CursorVisible = false;

            // 코루틴 로직
            Stopwatch watch = new Stopwatch();

            // 현재 플레이 시간
            Stopwatch watch2 = new Stopwatch();

            Player player = new Player();

            BulletManager bulletManager = new BulletManager();
            Random rand = new Random();





            int count = 0;

            watch.Start();
            while (true)
            {
                //if (player.GameOverCheck())
                //{
                //    Console.SetCursorPosition(0,20);
                //    Console.ReadKey(true);
                //    break;
                //}
                watch2.Start();

                // 플레이어 체력 , 시간 출력
                player.PlayerStatus(watch2);

                if (Console.KeyAvailable)
                {
                    player.PlayerMove();
                }

                if (watch.ElapsedMilliseconds > 100)
                {
                    watch.Restart();
                    player.CountHeart(bulletManager.bullets);

                    // 총알과 플레이어 좌표 비교를 통해 플레이어 목숨 컨트롤

                    // 랜덤 값 뽑아서 총알 활성화
                    bulletManager.BulletRandomXY(rand);

                    // 활성화 된 총알 좌표 증감
                    bulletManager.BulletXY();


                }

                // 총알 출력
                bulletManager.BulletPrint();

                // 플레이어 출력
                player.PlayerPrint();

            }

        }

    }
}