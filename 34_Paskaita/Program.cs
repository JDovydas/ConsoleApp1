using System.Runtime.InteropServices;

namespace _34_Paskaita
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await Task1();//.Wait();

            await Task2();

            Thread thread = new Thread(new ThreadStart(DoWork));
            Thread thread2 = new Thread(new ThreadStart(DoWork));

            thread.Start();
            thread2.Start();
            thread.Join();
            thread2.Join();

            /*
            ProgressBar progressBar = new ProgressBar();

            var incrementTask = IncrementBar(progressBar);
            var printTask = PrintBar(progressBar);

            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");


            await Task.WhenAll(incrementTask, printTask);
            */
        }
        static async Task<bool> IncrementBar(ProgressBar progressBar)
        {
            while (progressBar.Progress <= 99)
            {
                progressBar.Incriment();
                await Task.Delay(1000);
            }
            return true;
        }

        static async Task<bool> PrintBar(ProgressBar progressBar)
        {

            while (progressBar.Progress <= 99)
            {
                Console.WriteLine($"{progressBar.Progress}");
                await Task.Delay(3000);
            }
            return true;
        }

        static async Task Task1()
        {
            ProgressBar progressBar = new ProgressBar();

            var incrementTask = IncrementBar(progressBar);
            var printTask = PrintBar(progressBar).Result; //not suggested since we are blocking to get this result - becomes synchronous

            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");
            Console.WriteLine("Something");

        }

        static async Task Task2()
        {
            ProgressBar progressBar = new ProgressBar();
            var t = Task.Run(() => IncrementBar(progressBar));//This is used for long-running processes
            //{
            //    var printTask = PrintBar(progressBar);
            //});

            var incrementTask = IncrementBar(progressBar);
            var printTask = PrintBar(progressBar);

            await Task.WhenAll(incrementTask, printTask);
        }

        static void DoWork()
        {
            while (true)
            {
                Console.WriteLine("something");
            }
        }
    }
}