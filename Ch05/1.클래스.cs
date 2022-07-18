using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/18
 * 이름:김현동
 * 내용 : 클래스 실습하기 교제 p203
 * 
 * 클래스
 * -클래스는 객체를 생성하는 구조체이며,필드(속성)와 메서드 (기능)로 구성된다
 * -객체는 클래스의 실제 인스턴스로 new 연산을 통해서 생성된다.
 */

namespace Ch05
{
    internal class 클래스
    {
        static void Main1(string[] args)
        {
            Car sonata = new Car();

            //객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            //객체 기능 활용
            sonata.SpeedUP(80);
            sonata.SpeedDown(20);
            sonata.Show();

            //객체 생성
            Car benz = new Car();
            benz.name = "벤츠";
            benz.color = "검정색";
            benz.speed = 10;

            benz.SpeedUP(100);
            benz.SpeedDOWN(20);
            benz.Show();

            //Account 객체생성
            Account kb = new Account();
            Account wr = new Account();

            //Account 객체초기화
            kb.Bank = "";
            kb.id = "101-12-1010";
            kb.name = "김현동";
            kb.balance = 100000;

            wr.Bank = "";
            wr.id = "101-22/1010";
            wr.name = "이민수";
            wr.balance = 1;


            //Account 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(1000);
            kb.show();

            wr.Deposit(1);
            wr.Withdraw(1);
            wr.show();








        }
    }
}
