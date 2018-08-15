using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle
{
    public interface ICalendarService
    {
        int[] GetHolidays(int year, int month, string townCode);
    }
}
