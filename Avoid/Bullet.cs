using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{
    // 총알의 방향 - bool형식 보다 enum형식이 편리 할 것 같아 사용
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

        // BulletManager에서 사용됨
        // 건드려도 되는지 안되는지
        // -------------- public을 사용할지 프로퍼티 사용할지 (프로퍼티 사용 기준)

        BulletDirection _direction;

        public BulletDirection Direction
        {
            get { return _direction; }
            set
            {
                // BulletDirection 타입에 존재하는 값일 때만 값 넣을 수 있게
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



        public void BulletPrintUp(Bullet[] bullets ,BulletBefore[] bulletBefore, int i)
        {
            Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
            Console.WriteLine("▼");
            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
            Console.WriteLine("　");
        }

        public void BulletPrintDown(Bullet[] bullets, BulletBefore[] bulletBefore, int i)
        {
            Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
            Console.WriteLine("▲");
            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
            Console.WriteLine("　");
        }

        public void BulletPrintLeft(Bullet[] bullets, BulletBefore[] bulletBefore, int i)
        {
            Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
            Console.WriteLine("▶");
            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
            Console.WriteLine("　");
        }

        public void BulletPrintRight(Bullet[] bullets, BulletBefore[] bulletBefore, int i)
        {
            Console.SetCursorPosition(bullets[i].BulletX, bullets[i].BulletY);
            Console.WriteLine("◀");
            Console.SetCursorPosition(bulletBefore[i]._x, bulletBefore[i]._y);
            Console.WriteLine("　");
        }

        public bool BulletRangeMinX(Bullet bullet)
        {
            return 2 < bullet.BulletX;
        }
        public bool BulletRangeMaxX(Bullet bullet)
        {
            return bullet.BulletX < 58;
        }
        public bool BulletRangeMinY(Bullet bullet)
        {

            return 1 < bullet.BulletY;
        }
        public bool BulletRangeMaxY(Bullet bullet)
        {

            return bullet.BulletY < 28;
        }
    }
}
