using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;

namespace Avoid
{
    enum Choose
    {
        start,end,setting
    }
    internal class GamePlay
    {
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
                    Console.Clear();
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
                        setting.GameSetting();
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
        public void gamePlay(string playerSkin, int BulletLevel)
        {
            
            // 콘솔 사이즈 
            // Console.SetWindowSize(100, 40);

            // 콘솔에서 커서 안보이게
            Console.CursorVisible = false;

            // 코루틴 로직
            Stopwatch korutin = new Stopwatch();

            // 현재 플레이 시간
            Stopwatch playTime = new Stopwatch();

            // 시간에 따른 총알 나오는 벽 추가
            Stopwatch WallAddTime = new Stopwatch();

            // 설정에서 가져온 playerSkin 을 활용한 플레이어 생성
            Player player = new Player(playerSkin);

            BulletManager bulletManager = new BulletManager();

            // 랜덤으로 x좌표를 받기 위해 사용
            Random rand = new Random();


            // 총알 나오는 벽의 개수
            int wallCount = 1;

            bool gameOver = false;
            bool gameClear = false;


            string[] enddingMessage = new string[30];

            // 맵 출력
            Console.SetCursorPosition(0, 0);
            PrintMap();
            korutin.Start();
            WallAddTime.Start();
            playTime.Start();


            while (gameOver == false && gameClear == false)
            {
                if (Console.KeyAvailable)
                {
                    // 캐릭터 움직이기
                    player.PlayerMove();
                }
                // 플레이어 이동 반복문과 관계없이 실행
                else if (korutin.ElapsedMilliseconds > 80 - (BulletLevel *10))
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
                else if (ChecSecond(WallAddTime.ElapsedMilliseconds) > 10)
                {
                    WallAddTime.Restart();
                    wallCount += 1;
                }
                // 게임 클리어 조건 - 40초 생존
                else if (ChecSecond(playTime.ElapsedMilliseconds) >= 40)
                {
                    gameClear = true;
                }
                // 게임 오버 조건 
                else if (player.GameOverCheck())
                {
                    gameOver = true;
                }
                // 총알 출력
                bulletManager.BulletPrint();
                // 플레이어 출력
                player.PlayerPrint();
                // 플레이어 체력 , 시간 출력
                player.PlayerStatus(playTime);
            }

            // 엔딩 프린트 함수
            PrintGameResult(gameClear, gameOver);

        }

        public void PrintGameResult(bool gameClear, bool gameOver)
        {
            string[] lines = new string[30];
           
            if (gameClear == true)
            {
                lines = new string[]
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
            }
            else if (gameOver == true)
            {
                lines = new string[]
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
                Console.ForegroundColor = ConsoleColor.Red;
            }
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
            Console.ResetColor();
        }
        public long ChecSecond(long time)
        {
            return time / 1000;
        }

    }
}
