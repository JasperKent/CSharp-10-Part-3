using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Lambdas
{
    public class WeekdaySchedulerAttribute : SchedulerAttribute
    {
        public override bool CanRun(DateTime date) =>
            date.DayOfWeek is >= DayOfWeek.Monday and <= DayOfWeek.Friday;

    }
}
