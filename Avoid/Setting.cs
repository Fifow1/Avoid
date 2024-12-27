using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Avoid
{
    struct Arrow
    {
        int _y;
        public int _yBefore;

        public int Y
        {
            get
            {
                return _y;

            }
            set
            {
                if (value < 8)
                {
                    value = 8;
                }
                else if (value > 10)
                {
                    value = 10;
                }
                else
                {
                    _y = value;
                }
            }
        }
    }
    internal class Setting
    {
        string[] _characterArray;
        string _character;
        int _charArrayIndex;
        int _level;
        Arrow _arrow;

        public Setting()
        {
            _characterArray = new string[4] { "●", "★", "■", "▲" };
            _character = Character;
            CharArrayIndex = 0;
            Level = 1;
            _arrow.Y= 8;
            _arrow._yBefore = 8;
        }

        public string Character
        {
            get { return _character; }
            set 
            {
                _character = value;
            }
        }

        
        public int CharArrayIndex
        {
            get { return _charArrayIndex; }
            set 
            {
                if (value<0)
                {
                    value = 0;
                }
                else if (value >3)
                {
                    value = 3;
                }
                else
                {
                    _charArrayIndex = value; 
                }
            }
        }

        public int Level
        {
            get { return _level; }
            set 
            {
                if (value < 1)
                {
                    value = 1;
                }
                else if (value > 3)
                {
                    value = 3;
                }
                else
                {
                    _level = value;
                }
            }
        }

        public void GameSetting()
        {
            
            Console.SetCursorPosition(15, 2);
            Console.WriteLine("게임 세팅");
            Console.SetCursorPosition(10, 8);
            Console.Write("  게임 캐릭터 모습 :  " + _characterArray[_charArrayIndex]);
            Console.SetCursorPosition(10, 10);
            Console.Write("  총알 속도 레벨 : " + _level);
            while (true)
            {
                ConsoleKeyInfo keyInput = Console.ReadKey(true);

                _arrow._yBefore= _arrow.Y;

                if (keyInput.Key == ConsoleKey.W)
                {
                    _arrow.Y -= 2;
                }
                else if (keyInput.Key == ConsoleKey.S)
                {
                    _arrow.Y += 2;
                }
                else if (keyInput.Key == ConsoleKey.D)
                {
                    if (_arrow.Y == 8)
                    {
                        CharArrayIndex++;
                    }
                    else if (_arrow.Y == 10)
                    {
                        Level++;
                    }
                }
                else if (keyInput.Key == ConsoleKey.A)
                {
                    if (_arrow.Y == 8)
                    {
                        CharArrayIndex--;
                    }
                    else if (_arrow.Y == 10)
                    {
                        Level--;
                    }
                }
                else if (keyInput.Key == ConsoleKey.Enter)
                {
                    Character = _characterArray[CharArrayIndex];
                    Console.SetCursorPosition(0,0);
                    Console.WriteLine(Character);
                    Console.WriteLine(_characterArray[CharArrayIndex]);
                    Console.WriteLine(_characterArray[CharArrayIndex]);
                    Console.WriteLine(Character);
                    Console.ReadLine();
                    break;
                }

                Console.SetCursorPosition(8, _arrow._yBefore);
                Console.Write("　");
                Console.SetCursorPosition(8, _arrow.Y);
                Console.Write("▶");

                Console.SetCursorPosition(32, 8);
                Console.WriteLine(_characterArray[CharArrayIndex]);
                Console.SetCursorPosition(29, 10);
                Console.WriteLine(Level);
            }
        }
    }
}
