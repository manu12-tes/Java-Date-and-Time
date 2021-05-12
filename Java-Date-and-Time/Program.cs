using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Java_Date_and_Time
{
    class Program
    {
        public static String finDay(int mes,int dia,int año)
        {
            DateTime myDT = new DateTime(año, mes, dia, new GregorianCalendar());
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            myDT = myCal.AddDays(myDT, 5);

            return myCal.GetDayOfWeek(myDT).ToString();
        }
        static void Main(string[] args)
        {
            finDay(4,3,2002);
        }
    }
}
