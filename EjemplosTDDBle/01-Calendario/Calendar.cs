using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle
{
    public class Calendar
    {
        ICalendarService _serviceMock;
        public string CurrentTown;
        public int CurrentYear;
        public int CurrentMonth;
        public int[] Holidays;

        public Calendar(ICalendarService serviceMock)
        {
            _serviceMock = serviceMock;
            Holidays = new int[]{ 1,5};
        }
               
        public void DrawMonth()
        {
            // ... some business code here ...
            int[] holidays = _serviceMock.GetHolidays(CurrentYear,  CurrentMonth, CurrentTown);
        }
    }
}
