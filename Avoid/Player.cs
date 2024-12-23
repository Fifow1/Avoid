using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{
        struct PlayerBefore
        {
            public int _x;
            public int _y;
        }
        internal class Player
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

    }
