using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{
    enum BulletDirection
    {
        up, down, left, right
    }

    // 크기를 많이 차지하지 않을 것 같아 클래스가 아닌 구조체로 만듦
    struct BulletBefore
    {
        public int _x;
        public int _y;
    }
    internal class Bullet
    {
        int _x;
        int _y;
        bool _isFired;
        public int _count;
        BulletDirection _direction;

        public BulletDirection Direction
        {
            get { return _direction; }
            set
            {
                // 개발할때 BulletDirection 타입에 존재하는 값일 때만 값 넣을 수 있게
                if (Enum.IsDefined(typeof(BulletDirection), value))
                {
                    _direction = value;
                }
                else
                {

                }

            }
        }

        public Bullet()
        {
            _isFired = false;
            _direction = BulletDirection.up;
        }


        public int BulletX { get { return _x; } set { _x = value; } }
        public int BulletY { get { return _y; } set { _y = value; } }
        public bool IsFired { get { return _isFired; } set { _isFired = value; } }


        public int IncreaseBulletX(int IncreaseNum)
        {
            return _x + IncreaseNum;
        }
        public int DecreaseBulletX(int IncreaseNum)
        {
            return _x - IncreaseNum;
        }
        public int IncreaseBulletY(int IncreaseNum)
        {
            return _y + IncreaseNum;
        }
        public int DecreaseBulletY(int IncreaseNum)
        {
            return _y - IncreaseNum;
        }

    }
}
