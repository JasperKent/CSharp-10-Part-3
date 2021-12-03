using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Lambdas
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public abstract class SchedulerAttribute : Attribute
    {
        public abstract bool CanRun(DateTime date);
    }
}
