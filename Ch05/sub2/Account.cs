using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        //속성:private으로 캡슐화
        private string Bank;
        private string id;
        private string name;
        private int balance;

        //생성자 : 캡슐화된 속성을 초기화하기 위한 메서드
        public Account(string Bank, string id, string name, int balance)
        {
            this.Bank = Bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        //기능 : 일반적으로 외부에 기능을 제공하기 위해 public선언
        public void Deposit(int money)
        {
            this.balance += money;
        }
        public void Withdraw (int money)
        {
            this.balance -= money;
        }
        public void Show () 
        {
            Console.WriteLine("===============");
            Console.WriteLine("은행명 : " + Bank);
            Console.WriteLine("계좌번호 : " + id);
            Console.WriteLine("은행명 : " + name);
            Console.WriteLine("은행명 : " + balance);
            Console.WriteLine("================");
        }

    }
}
