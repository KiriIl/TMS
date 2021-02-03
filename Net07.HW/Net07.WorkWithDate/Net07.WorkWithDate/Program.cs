using System;

namespace Net07.WorkWithDate
{
    class Program
    {
        enum DaysInMonths
        {
            jan = 31,
            lFeb = 29,
            Feb = 28,
            mar = 31,
            apr = 30,
            may = 31,
            jun = 30,
            jul = 31,
            aug = 31,
            sep = 30,
            oct = 31,
            nov = 30,
            dec = 31
        }

        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            GetDayOfWeekEasyLevel();
            GetDayOfWeekMiddleLevel();
            GetDayOfWeekHardLevel();
        }

        private static void GetDayOfWeekHardLevel()
        {
            Console.WriteLine("Введите дату ");
            string dateStr = Console.ReadLine();
            string[] strArr = dateStr.Split('.');
            int dayInDate = int.Parse(strArr[0]);
            int monthInDate = int.Parse(strArr[1]);
            int yearInDate = int.Parse(strArr[2]);
            int leapDays = CalcLeapDays(yearInDate);
            int totalDays = 365 * (yearInDate - 1) + leapDays;
            for (int i = 1; i < monthInDate; i++)
            {
                totalDays += GetDaysByMonth(i, Isleap(yearInDate));
            }
            totalDays += dayInDate;
            Console.WriteLine(GetDayOfWeekByMod(totalDays));
            Console.WriteLine(totalDays);
        }

        private static int CalcLeapDays(int yearInDate)
        {
            bool currentYearIsLeap = Isleap(yearInDate);
            int leapDays = yearInDate / 4;
            if (currentYearIsLeap)
                leapDays--;
            int everyCentury = yearInDate / 100;
            int everyFourCentury = yearInDate / 400;
            return leapDays - everyCentury + everyFourCentury;
        }

        private static bool Isleap(int yearInDate) => yearInDate % 4 == 0;

        private static DaysOfWeek GetDayOfWeekByMod(int totalDays)
        {
            int mod = totalDays % 7;
            switch(mod)
            {
                case 1: return DaysOfWeek.Monday;
                case 2: return DaysOfWeek.Tuesday;
                case 3: return DaysOfWeek.Wednsday;
                case 4: return DaysOfWeek.Thursday;
                case 5: return DaysOfWeek.Friday;
                case 6: return DaysOfWeek.Saturday;
                case 0: return DaysOfWeek.Sunday;
                default: throw new Exception("Unexpected day of week");
            }
        }

        private static int GetDaysByMonth(int i, bool leapYear)
        {
            switch (i)
            {
                case 1: return (int)DaysInMonths.jan;
                case 2 when leapYear: return (int)DaysInMonths.lFeb;
                case 2 when !leapYear: return (int)DaysInMonths.Feb;
                case 3: return (int)DaysInMonths.mar;
                case 4: return (int)DaysInMonths.apr;
                case 5: return (int)DaysInMonths.may;
                case 6: return (int)DaysInMonths.jun;
                case 7: return (int)DaysInMonths.jul;
                case 8: return (int)DaysInMonths.aug;
                case 9: return (int)DaysInMonths.sep;
                case 10: return (int)DaysInMonths.oct;
                case 11: return (int)DaysInMonths.nov;
                case 12: return (int)DaysInMonths.dec;
                default: return 0;
            }
        }

        private static void GetDayOfWeekMiddleLevel()
        {
            DateTime date;
            string inputString;
            while (true)
            {
                Console.WriteLine("Введите дату ");
                inputString = Console.ReadLine();
                if (inputString.ToLower() == "exit")
                    return;
                else
                {
                    if (!DateTime.TryParse(inputString, out date))
                    {
                        Console.WriteLine("Дата введена неправильно");
                    }
                    else
                    {
                        Console.WriteLine(date.DayOfWeek);
                    }
                }
            }
        }

        private static void GetDayOfWeekEasyLevel()
        {
            string inputString;
            while (true)
            {
                Console.Write("Введите день недели ");
                inputString = Console.ReadLine();
                switch (inputString.ToLower())
                {
                    case "monday": Console.WriteLine("Понедельник"); break;
                    case "tuesday": Console.WriteLine("Вторник"); break;
                    case "wednsday": Console.WriteLine("Среда"); break;
                    case "thursday": Console.WriteLine("Четверг"); break;
                    case "friday": Console.WriteLine("Пятница"); break;
                    case "saturday": Console.WriteLine("Суббота"); break;
                    case "sunday": Console.WriteLine("Воскресенье"); break;
                    case "exit": return;
                    default: Console.WriteLine("Некорректный ввод дня недели"); break;
                }
            }
        }
    }
}