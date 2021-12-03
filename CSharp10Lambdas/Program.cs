using CSharp10Lambdas;
using System;

var worker = new Worker();

//var func1 = () => 42;
//var func2 = (ref int x) => x * 2;

//var func3 =  (int x) => x > 10 ? 42 : 43;

//var func4 = Math.Sin;

//var act1 = () => Console.WriteLine("Send the daily emails");

//Func<int, int> func =[return: WeekdayScheduler](x) => x * 2;

worker.Actions.Add([WeekdayScheduler]() => Console.WriteLine("Send the daily emails"));
worker.Actions.Add(() => Console.WriteLine("Tidy up the temp files"));

worker.Run();