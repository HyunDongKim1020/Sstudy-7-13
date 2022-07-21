using ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:7/20
 * 이름:김현동
 * 내용:인터페이스 실습하기 교제 p425
 * 
 * 인터페이스(interface)
 * - 클래스 설계를 위해 공통의 표준 가이드 역할을 위한 구조체
 * - 인터페이스를 활용해서 객체간 결합도를 완화
 */
namespace ch06
{
    internal class _2
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////
            //인터페이스로 공통 클래스 구조설계에 활용
            ////////////////////////////////////////
            LGRemotControl lg = new LGRemotControl();
            SamsungRemoteControl samsung = new SamsungRemoteControl();

            lg.PowerOn();
            lg.ChUp();
            lg.SoundUp();

            samsung.PowerOff();
            samsung.ChDown();
            samsung.SoundDown();


            ////////////////////////////////////////
            //인터페이스로 다중 상속에 활용
            ////////////////////////////////////////
            
            TV smartTV = new TV();
            smartTV.PowerOn();
            smartTV.Booting();
            smartTV.AccessInternet();

            ////////////////////////////////////////
            //인터페이스로 객체간 결합도 완화에 활용
            ////////////////////////////////////////
            Socket bulb = new Bulb();
            Socket cable = new Cable(bulb);

            Socket.SwitchOn();
            Socket.SwitchDown();
        }
    }
}
