using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoid
{

    internal class MainProgram
    {
        static void Main(string[] args)
        {
            GamePlay gamePlay = new GamePlay();
            Console.CursorVisible = false;

            gamePlay.ChoosePlayer();
        }
    }
}
