using System;
using System.Diagnostics;

namespace Avoid
{
    internal class GamePlay
    {
        public void ChoosePlayer()
        {
            Console.SetWindowSize(95, 40);
            Console.SetWindowPosition(0, 0);
            Console.WriteLine("\r\n                 ____                ___       ___               __      \r\n                /\\  _`\\             /\\_ \\     /\\_ \\             /\\ \\__   \r\n                \\ \\ \\L\\ \\   __  __  \\//\\ \\    \\//\\ \\       __   \\ \\ ,_\\  \r\n                 \\ \\  _ <' /\\ \\/\\ \\   \\ \\ \\     \\ \\ \\    /'__`\\  \\ \\ \\/  \r\n                  \\ \\ \\L\\ \\\\ \\ \\_\\ \\   \\_\\ \\_    \\_\\ \\_ /\\  __/   \\ \\ \\_ \r\n                   \\ \\____/ \\ \\____/   /\\____\\   /\\____\\\\ \\____\\   \\ \\__\\\r\n                    \\/___/   \\/___/    \\/____/   \\/____/ \\/____/    \\/__/\r");
            Console.WriteLine("\r\n            ____                                                           ___      \r\n           /\\  _`\\                               __                       /\\_ \\     \r\n           \\ \\,\\L\\_\\    __  __   _ __   __  __  /\\_\\    __  __     __     \\//\\ \\    \r\n            \\/_\\__ \\   /\\ \\/\\ \\ /\\`'__\\/\\ \\/\\ \\ \\/\\ \\  /\\ \\/\\ \\  /'__`\\     \\ \\ \\   \r\n              /\\ \\L\\ \\ \\ \\ \\_\\ \\\\ \\ \\/ \\ \\ \\_/ | \\ \\ \\ \\ \\ \\_/ |/\\ \\L\\.\\_    \\_\\ \\_ \r\n              \\ `\\____\\ \\ \\____/ \\ \\_\\  \\ \\___/   \\ \\_\\ \\ \\___/ \\ \\__/.\\_\\   /\\____\\\r\n               \\/_____/  \\/___/   \\/_/   \\/__/     \\/_/  \\/__/   \\/__/\\/_/   \\/____/\r\n                                                                                    \r\n                                                                                    \r\n");
            Console.WriteLine("\n\n\n\n");
            string[] arrayPaly = { " 1.게임시작 ", " 2,게임종료 " };
            while (true)
            {
                Console.SetCursorPosition(26, 25);
                for (int i = 0; i < arrayPaly.Length; i++)
                {

                    Console.Write(arrayPaly[i] + "　　　　　　　　");
                }
                ConsoleKeyInfo aa = Console.ReadKey(true);

                if (aa.Key == ConsoleKey.D1)
                {
                    arrayPaly[0] = "[ 1.게임시작 ]";
                    arrayPaly[1] = " 2.게임종료 ";
                }
                else if (aa.Key == ConsoleKey.D2)
                {
                    arrayPaly[0] = " 1.게임시작 ";
                    arrayPaly[1] = "[ 2.게임종료 ]";
                }
                else if (aa.Key == ConsoleKey.Enter)
                {
                    if (arrayPaly[0] == "[ 1.게임시작 ]")
                    {
                        gamePlay();
                    }
                    else if (arrayPaly[1] == "[ 2.게임종료 ]")
                    {
                        break;
                    }
                }
            }
        }
        public void PrintMap()
        {
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

        }

        public void gamePlay()
        {
            Console.Clear();
                PrintMap();
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
