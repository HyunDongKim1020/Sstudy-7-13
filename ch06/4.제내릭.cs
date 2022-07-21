using ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날자7/21
 * 이름:김현동
 * 내용:제네릭 실습하기 p395
 * 
 * 제네릭(Generic)
 * -클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법 요소
 * -제네릭 사용으로 클래스를 범용성 있게 사용한다 
 */

namespace ch06
{

    class FruitBox
    {
        private Apple fruit;

        public FruitBox(Apple fruit)
        {
            this.fruit = fruit;
        }

        public void Fruit()
        {
            fruit.Show();
        }

        public void GetFruit(){
            return fruit;
        }
    }
    internal class _4
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("한국", 3000);

            FruitBox box1 = new FruitBox(apple);

            
        }
    }
}
