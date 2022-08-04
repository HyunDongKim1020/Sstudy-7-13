using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._09
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("생일입력(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split("/");

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            //올해 1월 1일부터 오늘까지 날짜 수
            totalDays += DayOfYear(tYear, tMonth, tDay);

            //태어난 해의 생일부터 그해 마지막 날까지의 날짜 ㅛㅜ
            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for(int year = bYear +1; year < tYear; year++)
            {
                if (IsLeapYear(year))
                    totalDays += 366;
                else
                    totalDays += 365;
            }
            Console.WriteLine("태어난 날부터 오늘까지 일수 : {0}",totalDays);
        }

        //평년을 기준으로 각 월의 누적 날짜 수
        public static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        public static int DayOfYear(int Year,int Month, int Day)
        {
            return days[Month - 1] + Day + (Month > 2 && IsLeapYear(Year) ? 1 : 0);
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
