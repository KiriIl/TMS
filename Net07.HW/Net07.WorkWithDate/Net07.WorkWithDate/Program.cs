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
            //GetDayOfWeekEasyLevel();
            Console.Write("Введите дату ");
            string date = "01.03.0103";
            //date = Console.ReadLine();
            GetDayOfWeekMiddleLevel(date);
            GetDayOfWeekHardLevel(date);
        }

        private static void GetDayOfWeekHardLevel(string dateStr)
        {
            string[] strArr = dateStr.Split('.');
            int dayInDate = int.Parse(strArr[0]);
            int monthInDate = int.Parse(strArr[1]);
            int yearInDate = int.Parse(strArr[2]);
            int leapDays;



            if (isleap(yearInDate))
                leapDays = yearInDate / 4 - 1;
            else
                leapDays = yearInDate / 4;


            int totalDays = 365 * (yearInDate - 1) + leapDays;
            for (int i = 1; i < monthInDate; i++)
                totalDays += GetDaysByMonth(i, isleap(yearInDate));
            totalDays += dayInDate;
            Console.WriteLine(GetDayOfWeekByMod(totalDays));
            Console.WriteLine(totalDays);
        }

        private static bool isleap(int yearInDate)
        {
            if (yearInDate % 4 == 0)
                return true;
            else
                return false;
        }

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
                default: throw new Exception();
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

        private static void GetDayOfWeekMiddleLevel(string dateStr)
        {
            DateTime date = DateTime.Parse(dateStr);
            Console.WriteLine(date.DayOfWeek);
        }

        private static void GetDayOfWeekEasyLevel()
        {
            while(true)
            {
                Console.Write("Введите день недели ");
                string inputString = Console.ReadLine();
                switch (inputString.ToLower())
                {
                    case "понедельник": Console.WriteLine($"Перевод: {DaysOfWeek.Monday}"); break;
                    case "вторник": Console.WriteLine($"Перевод: {DaysOfWeek.Tuesday}"); break;
                    case "среда": Console.WriteLine($"Перевод: {DaysOfWeek.Wednsday}"); break;
                    case "Четверг": Console.WriteLine($"Перевод: {DaysOfWeek.Thursday}"); break;
                    case "пятница": Console.WriteLine($"Перевод: {DaysOfWeek.Friday}"); break;
                    case "суббота": Console.WriteLine($"Перевод: {DaysOfWeek.Saturday}"); break;
                    case "воскресенье": Console.WriteLine($"Перевод: {DaysOfWeek.Sunday}"); break;
                    case "exit": return;
                    default:  break;
                }
            }
        }
        //1827 - понедельник
        //1827 / 7 == 261, остаток 0 -вс
        //1828 / 7 = 261,1428 остаток 1 -пн
        //1829 / 7 = 261,2857 остаток 2 -вт
        //1830 / 7 = 261,4285 остаток 3 -ср
        //1831 / 7 = 261,5714 остаток 4 -чт
        //1832 / 7 = 261,7142 остаток 5 -пт
        //1833 / 7 = 261,8571 остаток 6 -сб
        //1834 / 7 = 262 остаток 0 -вс
    }
}