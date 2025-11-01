using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {

            if (m < 1 || m > 12)
            {
                return "Неверный номер месяца";
            }

            if (n < 1)
            {
                return "Неверный номер дня";
            }

            int daysInMonth = GetDaysInMonth(m, true);

            if (n > daysInMonth)
            {
                return "Неверный номер дня для данного месяца";
            }

            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }

        private int GetDaysInMonth(int month, bool isLeapYear)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return isLeapYear ? 29 : 28;
                default:
                    return 0;
            }
        }
    }
}