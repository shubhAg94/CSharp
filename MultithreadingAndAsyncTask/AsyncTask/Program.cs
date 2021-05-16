using System;
using System.Threading.Tasks;

namespace AsyncTask
{
    class Program
    {

        public static async Task BaseTask()
        {
            Console.WriteLine("BaseTask Starts:");
            await Task.Delay(3000);
            Console.WriteLine("BaseTask Ends:");
        }
        public async static Task DoTaskOne()
        {
            Console.WriteLine("Task One Starts");
            await BaseTask();
            //await Task.Delay(5000);
            Console.WriteLine("Task One Ends");
        }
        public static void DoTaskTwo() => Console.WriteLine("Task Two");

        public static void Main(string[] args)
        {
            _ = DoTaskOne();
            Console.WriteLine("Hello World!");
            DoTaskTwo();

            Task task = new Task(() =>
            {
                Task.Delay(6000);
                Console.WriteLine("Task printing");
                Console.ReadKey();
            });
            task.Start();
            Console.WriteLine("Task Started: ");

            Console.ReadKey();
        }
    }
}
