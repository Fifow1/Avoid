using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        string _skin;
        PlayerBefore playerBefore;
        public Player(string skin)
        {
            _skin = skin;
            _x = 26;
            _y = 16;
            _heart = 3;
            playerBefore._x = _x;
            playerBefore._y = _y;
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_skin);
        }



        public int PlayerX 
        { 
            get { return _x; } 
            set 
            {
                if (2 < value && value < 58)
                {
                    _x = value;
                }
                else if(value >58)
                {
                    _x = 58;
                }
                else if (value < 2)
                {
                    _x = 2;
                }
            } 
        }
        public int PlayerY 
        {
            get { return _y; } 
            set 
            {
                if (1 < value && value < 29)
                {
                    _y = value; 
                }
                else if (value > 29)
                {
                    value = 29;
                }
                else if (value < 1)
                {
                    value = 1;
                }
            } 
        }
        public int PlayerHp { get { return _heart; } set { _heart = value; } }
        public bool GameOverCheck()
        {
            return _heart == 0;
        }

        public void CountHeart(Bullet[] bullets)
        {
            for (int i = 1; i < bullets.Length; i++)
            {
                if (PlayerX == bullets[i].BulletX && PlayerY == bullets[i].BulletY)
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
            Console.WriteLine("생존 시간 : " + watch2.ElapsedMilliseconds / 1000 + " 초");
        }
        public void PlayerPrint()
        {
            Console.SetCursorPosition(playerBefore._x, playerBefore._y);
            Console.WriteLine("　");
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_skin);
        }

        public void PlayerMove()
        {
            ConsoleKeyInfo keyInput = Console.ReadKey(true);
            playerBefore._x = _x;
            playerBefore._y = _y;

            //  -- ▶
            if (keyInput.Key == ConsoleKey.D)
            {
                PlayerX += 2;
            }

            //  ◀--
            else if (keyInput.Key == ConsoleKey.A)
            {
                PlayerX -= 2;
            }

            //  ▲
            //  ㅣ

            else if (keyInput.Key == ConsoleKey.W)
            {
                PlayerY--;
            }

            //  ㅣ
            //  ▼
            else if (keyInput.Key == ConsoleKey.S)
            {
                PlayerY++;
            }

            
        }
    }
}

