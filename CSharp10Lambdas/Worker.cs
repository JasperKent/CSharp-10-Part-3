using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp10Lambdas
{
    public  class Worker
    {
        public List<Action> Actions { get; } = new();

        public void Run()
        {
            foreach (var action in Actions)
            {
                var attr = action.Method.GetCustomAttribute<SchedulerAttribute>();

                if (attr == null || attr.CanRun(DateTime.UtcNow - new TimeSpan(3,0,0,0)))
                    action();
            }
        }
    }
}
