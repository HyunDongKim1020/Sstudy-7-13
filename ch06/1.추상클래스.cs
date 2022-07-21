using ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 7/20일
 * 이름: 김현동
 * 내용: 추상 클래스 실습하기 p 230
 * 
 * 추상클래스(Abstract Class)
 *  - 공통의 기능은 하나의 메서드로 정의하고 개별적인 기능은 상속 받아 override 메서드로 정의하는 추상메서드를 갖는 클래스
 *  - 오직 상속을 목적으로 설계되는 클래스 
 */
namespace ch06
{
    internal class _1
    {
        static void Main(string[] args)
        {
            //추상 클래스는 객체생성 할수 없음 ex)Car car = new Car()x
            Car sedan = new Sedan("그랜져", "검정", 0, 2000);
            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            Car truck = new Truck("포터", "파랑", 0, 1);
            truck.SpeedUp(80);
            truck.SpeedDown(20);
            truck.Show();
        }
    }
}
