
namespace _33_Paskaita_Async_Await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //List<Task<string>> tasks = new List<Task<string>>();

            //tasks.Add(PerformCalculationAsync("Task 1", 6000));
            //tasks.Add(PerformCalculationAsync("Task 2", 3000));
            //tasks.Add(PerformCalculationAsync("Task 3", 12000));

            //var finishedTasks = await Task.WhenAll(tasks);

            //foreach (var task in finishedTasks)
            //{
            //    Console.WriteLine($"First response received: {task}");
            //}

            ///Task: 001

            //ProgressBar progressBar = new ProgressBar();

            //Task progressTaskByOne = RunProgressBarAsyncOne(progressBar);

            //Task progressTaskByThree = RunProgressBarAsyncThree(progressBar);


            //await Task.WhenAny(progressTaskByOne, progressTaskByThree);

            ///Task: 002

            await ScanDirectory();

        }

        static async Task RunProgressBarAsyncOne(ProgressBar progressBar)
        {
            while (progressBar.Progress < 100)
            {
                progressBar.Progress++;
                Console.WriteLine($"Progress - increase every second: {progressBar.Progress}%");
                await Task.Delay(1000);
            }
        }

        static async Task RunProgressBarAsyncThree(ProgressBar progressBar)
        {

            while (true)// (progressBar.Progress < 100)
            {
                Console.WriteLine($"Progress - output progress every 3 seconds: {progressBar.Progress}%");
                await Task.Delay(3000);
            }
        }

        static public async Task ScanDirectory()
        {


            DirectoryInfo location = new DirectoryInfo(@"C:\Users\djuod\source\repos\ConsoleApp1\31_ATM");

            while (true)
            {
                foreach (FileInfo file in location.GetFiles())
                {
                    Console.WriteLine($"Files: {file.Name}");
                    await Task.Delay(5000);
                }


            }
        }








        //static async Task<string> PerformCalculationAsync(string taskName, int delay)
        //{
        //    Console.WriteLine($"{taskName} started");
        //    await Task.Delay(delay);
        //    Console.WriteLine($"{taskName} completed.");

        //    return $"{taskName} result: Calculation done in {delay} milliseconds";

        //}
    }
}