using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{
    internal class Monster 
    {
        public int _xM;
        public int _yM;

        public Queue<(int,int)> _playerVector;

        public Monster()
        {
            _playerVector = new Queue<(int,int)>();
        }

        public void ooooo(Player player)
        {
            
        }

    }
}
