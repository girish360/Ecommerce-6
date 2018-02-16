using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common.DateServices
{
    public enum Days
    {
        Pazar =0,
        Pazartesi =1,
        Salı=2,
        Çarşamba=3,
        Perşembe=4,
        Cuma=5,
        Cumartesi=6
    }

    public enum Months
    {
        Ocak =1,
        Şubat=2,
        Mart=3,
        Nisan=4,
        Mayıs=5,
        Haziran=6,
        Temmuz=7,
        Ağustos=8,
        Eylül=9,
        Ekim=10,
        Kasım=11,
        Aralık=12,

    }
    
    public static class DateService
    {
        public static string[] MonthArray = Enum.GetNames(typeof(Months)).ToArray();

        public static string[] daysArray = Enum.GetNames(typeof(Days)).ToArray();

        public static string GetDateInfoTurkishLongDateFormat(DateTime date)
        {
            var dateIndex = date.Day;
            var monthIndex = date.Month;
            var year = date.Year;
            var dayIndex = date.TimeOfDay.Days;

            string dayName=""; 
            string Monthname = MonthArray[monthIndex];


            switch (dayIndex)
            {
                case (int)Days.Pazar:
                    dayName = Days.Pazar.ToString();
                    break;
                case (int)Days.Pazartesi:
                        dayName = Days.Pazartesi.ToString();
                    break;
                case (int)Days.Salı:
                    dayName = Days.Salı.ToString();
                    break;
                case (int)Days.Çarşamba:
                    dayName = Days.Çarşamba.ToString();
                    break;
                case (int)Days.Perşembe:
                    dayName = Days.Perşembe.ToString();
                    break;
                case (int)Days.Cuma:
                    dayName = Days.Cuma.ToString();
                    break;
                case (int)Days.Cumartesi:
                    dayName = Days.Cumartesi.ToString();
                    break;
                

            }
            return dateIndex + " " + Monthname + " " + year + " " + dayName;




        }


    }
}
