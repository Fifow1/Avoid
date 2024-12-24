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
}
