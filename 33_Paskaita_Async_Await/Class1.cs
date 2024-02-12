using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Paskaita_Async_Await
{
    internal class Class1
    {
        //static async Task Main(string[] args)
        //{
        ////Task1
        //List<Task<string>> tasks = new List<Task<string>>();

        //tasks.Add(PerformCalculationAsync("Task 1", 3000));
        //tasks.Add(PerformCalculationAsync("Task 2", 1000));
        //tasks.Add(PerformCalculationAsync("Task 3", 3000));

        //var firstToFinish = await Task.WhenAny(tasks);
        //string result = await firstToFinish;

        //Console.WriteLine($"First response received: {result}");
        //tasks.Remove(firstToFinish);

        //await Task.Delay(4000);

        //firstToFinish = await Task.WhenAny(tasks);
        //result = await firstToFinish;
        //Console.WriteLine($"First response received: {result}");

        //Task2

        //List<Task<string>> tasks = new List<Task<string>>();

        //tasks.Add(PerformCalculationAsync("Task 1", 3000));
        //tasks.Add(PerformCalculationAsync("Task 2", 1000));
        //tasks.Add(PerformCalculationAsync("Task 3", 3000));

        //var finishedTasks = await Task.WhenAll(tasks);

        //foreach (var task in finishedTasks)
        //{
        //    Console.WriteLine($"First response received: {task}");

        //}

        //}


        //Task1
        //static async Task<string> PerformCalculationAsync(string taskName, int delay)
        //{
        //    Console.WriteLine($"{taskName} started");
        //    await Task.Delay(delay);
        //    Console.WriteLine($"{taskName} completed.");

        //    return $"{taskName} result: Calculation done in {delay} milliseconds";

        //}

        ////static async Task<string> PerformCalculationAsync(string taskName, int delay)
        ////{
        ////    Console.WriteLine($"{taskName} started");
        ////    await Task.Delay(delay);
        ////    Console.WriteLine($"{taskName} completed.");

        ////    return $"{taskName} result: Calculation done in {delay} milliseconds";

        ////}
    }
}
