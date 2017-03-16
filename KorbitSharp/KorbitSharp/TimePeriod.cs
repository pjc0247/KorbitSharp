using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorbitSharp
{
    public enum TimePeriod
    {
        Minute,
        Hour,

        /// <summary>
        /// last 24 hours
        /// </summary>
        Day
    }

    static class TimePeriodExt
    {
        public static string ToPeriodString(this TimePeriod period)
        {
            if (period == TimePeriod.Minute) return "minute";
            else if (period == TimePeriod.Hour) return "hour";
            else if (period == TimePeriod.Day) return "day";

            throw new NotImplementedException($"{period}");
        }
    }
}
