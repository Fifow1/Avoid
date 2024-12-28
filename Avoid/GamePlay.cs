using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Avoid
{
    enum Choose
    {
        start,end,setting
    }
    internal class GamePlay
    {
        // 설정에서 캐릭터 모습을 바꿀 수 있게

        public void ChoosePlayer()
        {
            Setting setting = new Setting();

            Console.SetWindowSize(95, 40);
            string[] arrayPaly = { " 1.게임시작 ", " 2.게임종료 "," 3.게임설정 " };
            while (true)
            {
                Console.ResetColor();
                Console.Clear();
                Console.SetWindowPosition(0, 0);
                Console.WriteLine("\r\n                 ____                ___       ___               __      \r\n                /\\  _`\\             /\\_ \\     /\\_ \\             /\\ \\__   \r\n                \\ \\ \\L\\ \\   __  __  \\//\\ \\    \\//\\ \\       __   \\ \\ ,_\\  \r\n                 \\ \\  _ <' /\\ \\/\\ \\   \\ \\ \\     \\ \\ \\    /'__`\\  \\ \\ \\/  \r\n                  \\ \\ \\L\\ \\\\ \\ \\_\\ \\   \\_\\ \\_    \\_\\ \\_ /\\  __/   \\ \\ \\_ \r\n                   \\ \\____/ \\ \\____/   /\\____\\   /\\____\\\\ \\____\\   \\ \\__\\\r\n                    \\/___/   \\/___/    \\/____/   \\/____/ \\/____/    \\/__/\r");
                Console.WriteLine("\r\n            ____                                                           ___      \r\n           /\\  _`\\                               __                       /\\_ \\     \r\n           \\ \\,\\L\\_\\    __  __   _ __   __  __  /\\_\\    __  __     __     \\//\\ \\    \r\n            \\/_\\__ \\   /\\ \\/\\ \\ /\\`'__\\/\\ \\/\\ \\ \\/\\ \\  /\\ \\/\\ \\  /'__`\\     \\ \\ \\   \r\n              /\\ \\L\\ \\ \\ \\ \\_\\ \\\\ \\ \\/ \\ \\ \\_/ | \\ \\ \\ \\ \\ \\_/ |/\\ \\L\\.\\_    \\_\\ \\_ \r\n              \\ `\\____\\ \\ \\____/ \\ \\_\\  \\ \\___/   \\ \\_\\ \\ \\___/ \\ \\__/.\\_\\   /\\____\\\r\n               \\/_____/  \\/___/   \\/_/   \\/__/     \\/_/  \\/__/   \\/__/\\/_/   \\/____/\r\n                                                                                    \r\n                                                                                    \r\n");
                Console.WriteLine("\n\n\n\n");
                Console.SetCursorPosition(18, 25);
                for (int i = 0; i < arrayPaly.Length; i++)
                {

                    Console.Write(arrayPaly[i] + "　　　　　　");
                }
                ConsoleKeyInfo aa = Console.ReadKey(true);

                if (aa.Key == ConsoleKey.D1)
                {
                    arrayPaly[0] = "[ 1.게임시작 ]";
                    arrayPaly[1] = " 2.게임종료 ";
                    arrayPaly[2] = " 3.게임설정 ";
                }
                else if (aa.Key == ConsoleKey.D2)
                {
                    arrayPaly[0] = " 1.게임시작 ";
                    arrayPaly[1] = "[ 2.게임종료 ]";
                    arrayPaly[2] = " 3.게임설정 ";
                }
                else if (aa.Key == ConsoleKey.D3)
                {
                    arrayPaly[0] = " 1.게임시작 ";
                    arrayPaly[1] = " 2.게임종료 ";
                    arrayPaly[2] = "[ 3.게임설정 ]";
                }
                else if (aa.Key == ConsoleKey.Enter)
                {
                    if (arrayPaly[0] == "[ 1.게임시작 ]")
                    {
                        gamePlay(setting.Character,setting.Level);

                    }
                    else if (arrayPaly[1] == "[ 2.게임종료 ]")
                    {
                        break; 
                    }
                    else if (arrayPaly[2] == "[ 3.게임설정 ]")
                    {
                       
                        Console.Clear();
                        setting.GameSetting();
                    }
                }
            }
        }
        public void PrintMap()
        {
            //Console.BackgroundColor = ConsoleColor.Green;
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


        

        public void gamePlay(string playerSkin, int BulletLevel)
        {
            Console.Clear();
            PrintMap();
            Console.SetWindowSize(100, 40);
            // 콘솔에서 커서 안보이게
            //Console.CursorVisible = false;

            // 코루틴 로직
            Stopwatch korutin = new Stopwatch();

            // 현재 플레이 시간
            Stopwatch playTime = new Stopwatch();

            // 시간에 따른 총알 나오는 벽 추가
            Stopwatch WallAddTime = new Stopwatch();

            Player player = new Player(playerSkin);
            BulletManager bulletManager = new BulletManager();

            Random rand = new Random();


            // 총알 나오는 벽의 개수
            int wallCount = 1;


            string[] enddingMessage = new string[30];


            korutin.Start();
            WallAddTime.Start();
            playTime.Start();


            while (true)
            {
                if (player.GameOverCheck())
                {
                    PrintGameOverEndding();
                    break;
                }

                if (Console.KeyAvailable)
                {
                    // 캐릭터 움직이기
                    player.PlayerMove();
                }

                // 플레이어 이동 반복문과 관계없이 실행
                if (korutin.ElapsedMilliseconds > 90 - (BulletLevel *10))
                {
                    korutin.Restart();

                    // 총알과 플레이어 좌표 비교를 통해 플레이어 목숨 컨트롤
                    player.CountHeart(bulletManager.bullets);


                    // 랜덤 값 뽑아서 총알 활성화
                    bulletManager.BulletRandomXY(rand, wallCount);

                    // 활성화 된 총알 좌표 증감
                    bulletManager.BulletXY();


                }
                // 10초마다 총알 나오는 벽 추가
                if (WallAddTime.ElapsedMilliseconds / 1000 > 10)
                {
                    WallAddTime.Restart();
                    wallCount += 1;

                    

                }
                // 게임 클리어 조건 - 40초 생존
                if (playTime.ElapsedMilliseconds / 1000 >= 40)
                {
                    PrintGameClearEndding();
                    break;
                }

                // 총알 출력
                bulletManager.BulletPrint();

                // 플레이어 출력
                player.PlayerPrint();
                // 플레이어 체력 , 시간 출력
                player.PlayerStatus(playTime);
            }
        }
        public void PrintGameClearEndding()
        {
            string[] lines = new string[]
                {
                        "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　■■■■　■　　　　■■■■　■■■■　■■■■　　■",
                        "■　　　■　　　　■　　　　■　　　　■　　■　■　　■　　■",
                        "■　　　■　　　　■　　　　■■■■　■■■■　■■■■　　■",
                        "■　　　■　　　　■　　　　■　　　　■　　■　■　■　　　■",
                        "■　　　■■■■　■■■■　■■■■　■　　■　■　　■　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"
                };
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(0, i);
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            }
            for (int i = 30; i > 0; i--)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(0, i);
                Console.WriteLine(lines[i]);

            }
        }
        public void PrintGameOverEndding()
        {
            for (int i = 0; i < 31; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(50);
                Console.SetCursorPosition(0, i);
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            }


            Console.SetCursorPosition(0, 0);
            string[] lines = new string[]
            {
                        "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　■■■■■　　■■■■■　　■　　　■　　■■■■　　■",
                        "■　　■　　　　　　■　　　■　　■■　■■　　■　　　　　■",
                        "■　　■　　■■　　■■■■■　　■　■　■　　■■■■　　■",
                        "■　　■　　　■　　■　　　■　　■　■　■　　■　　　　　■",
                        "■　　■■■■■　　■　　　■　　■　■　■　　■■■■　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　■■■■■　　■　　　■　　■■■■■　　■■■■　　■",
                        "■　　■　　　■　　■　　　■　　■　　　　　　■　　■　　■",
                        "■　　■　　　■　　■　　　■　　■■■■■　　■■■■　　■",
                        "■　　■　　　■　　　■　■　　　■　　　　　　■　■　　　■",
                        "■　　■■■■■　　　　■　　　　■■■■■　　■　　■　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■　　　　　　　　　　　　　　　　　　　　　　　　　　　　　■",
                        "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"
            };

            for (int i = 30; i > 0; i--)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(0, i);
                Console.WriteLine(lines[i]);

            }

        }

    }
}
