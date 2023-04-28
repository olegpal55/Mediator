using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class CalendarEventArgs : EventArgs
    {
        public bool IsWeekend { get; set; }
        public bool IsTrashDay { get; set; }
        public DayOfWeek Day { get; set; }

        public List<CalendarEventTypes> DayEvents { get; set; }
    }
}
