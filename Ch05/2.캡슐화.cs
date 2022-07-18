using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 2022/7/18일
 * 이름:김현동
 * 내용:캡슐화 실습하기 교제 p 203
 * 
 * 캡슐화
 * = 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보(속성)를 은닉하는 특성
 * = 캡슐화를 위한 접근 제한자 : public , private , protected등을 사용한다
 * = 은닉된 정보의 안전한 제공을 위해 Getter , Setter를 사용 (프로퍼티)
 */

namespace Ch05
{
    internal class Class1
    {
        static void Main2(string[] args)
        {
            //객체생성과 초기화
            Account kb = new Account("국민은행", "101 - 12 - 1010","김현동", 100000);

            //객체 활용
            kb.Deposit(40000);
            kb.Withdraw(1000);
            
            //캡슐화로 취약코드 예방
            //kb.balance--;

            kb.Show();

            Car sonata = new Car("소나타", "흰색", 10);
            sonata.SpeedUp(100);
            sonata.SpeedDown(100);
            sonata.Show();

            sonata.Name = "소나타 EF";
            sonata.Color = "검정색";
            sonata.Speed = 10;

            sonata.Show();

            //Getter , Setter  활용한 객체
            Car bmw = new Car();


            bmw.Name = "소나타g";
            bmw.Color = "금색";
            bmw.Speed = 10;

            Console.WriteLine("bmw name :" +bmw.Name);
            Console.WriteLine("bmw color :" +bmw.Color);
            Console.WriteLine("bmw speed :" +bmw.Speed);
        }



    }
}
