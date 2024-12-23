using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {

        // 매개변수 디폴트 값
        class Player
        {
            int level;
            string name;


            // 디폴트 매개변수 순서 중요!!
            public Player(int _level, string _name = "함승윤")
            {
                this.level = _level;
                this.name = _name;
            }

            public Player()
            {

            }


        }



        class Bullet
        {
            int posX;
            int posY;
            string bulletSymbol;





            // 오버로딩
            // 다른 언어에서는 같은 이름인 함수를 만들수 없지만 
            // c#에서는 이름이 같아도 인자값이 다르면 사용가능

            public Bullet()
            {
                Console.WriteLine("나생성");


            }

            public Bullet(int _X, int _y, string _symbol)
            {
                posX = _X;
                posY = _y;
                bulletSymbol = _symbol;
                Console.WriteLine(" 나 생성");

            }

            public void PrintPlayerPosition()
            {
                Console.WriteLine($"플레이어 좌표 : {posX} , {posY}");
            }
            public void PrintPlayerPosition(int a)
            {
                Console.WriteLine($"플레이어 좌표 : {posX} , {posY}");
            }



            //public int POSX
            //{
            //    get
            //    {

            //        return posX;
            //    }
            //    set
            //    {

            //        posX = value;

            //    }
            //}

            //public int POSX
            //{
            //    get
            //    {

            //        return posX;
            //    }
            //    set
            //    {

            //        posX = value;

            //    }
            //}



            //public string BULLET
            //{
            //    get
            //    {

            //        return posX;
            //    }
            //    set
            //    {

            //        posX = value;

            //    }
            //}

        }


        // 설계도
        class Car
        {
            int posx;
            int posY;
            public float maxSpeed;
            private int carNumber;



            public void MoveForeard(int inputx)
            {
                posx += inputx;
            }

            public void ChangeCarNum(int input)
            {
                carNumber = input;
            }

            public int GetCarNum() 
            { 
                return carNumber;
            }

            public void SetCarNum(int input)
            {
                carNumber = input;
            }

            // 정보은닉


            // 프로퍼티 (프로퍼티 속성)
            // 변수의 입출력에 조건 걸기
            public int POSX
            {
                get
                {

                    return posx;
                }
                set
                {
                    if(value > 1920)
                    {
                        posx = 1920;
                    }
                    else
                    {
                        posx = value;
                    }

                    posx = value;
                }
            }


            // 가독성이 좋지 않음 , 필요할 때만 사용
            public string MyAutoName
            {
                get;set;
            }
        }

        static void Main(string[] args)
        {
            Player myPlayer = new Player(22 , "");
            //Bullet bullet1 = new Bullet(1,1,"▶");
            //Bullet bullet2 = new Bullet(12,12,"▶");
            //Bullet bullet3 = new Bullet(5,5,"▶");

            Bullet bullet = new Bullet();

            //Console.WriteLine(myCa.posx);

            //myCa.ChangeCarNum(123);

            //Console.WriteLine(myCa.GetCarNum());


            //myCa.POSX = 123;
            //Console.WriteLine(myCa.POSX);
            //myCa.MyAutoName

            // class는 참조형식이기 때문에 new로 class크기 만큼 공간을 만들어줘야함
            // Car myCar; == int[] myArr;
            // Car car = new Car();
            // car.posx = 1;
            // Console.WriteLine(car.posx);
            // struct와 class는 같음

            // 구조체(값타입) = 구성 요소가 16바이트 미만일 때
            // class(참조형) = 구성 요소 16바이트보다 클 때

            // Car myCar2 = car;

        }


        // 지역변수 = 스택에 담김 , 지역에서 벗어나면 사라짐
        //static void AddNumbers(int a , int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //}




        // 메소드
        // 자동차를 인자로 받고, 이동할 x정수를 받아서 자동차 x에 반영

    }

}
