using System;
using System.Threading.Tasks;

namespace TaskContinuation
{
    class Program
    {
        public static async Task<string> BaseTask()
        {
            Console.WriteLine("BaseTask Starts:");
            await Task.Delay(3000);
            Console.WriteLine("BaseTask Ends:");
            return "BaseTask Ends";
        }

        public static async Task Main(string[] args)
        {
            // Execute the antecedent.
            //Task<DayOfWeek> taskA = Task.Run(() => DateTime.Today.DayOfWeek);

            // Execute the continuation when the antecedent finishes.
            //await taskA.ContinueWith(antecedent => Console.WriteLine("Today is {0}.", antecedent.Result));


            // Execute the antecedent.
            Task<string> taskBase = Task.Run(() => BaseTask());

            // Execute the continuation when the antecedent finishes.
            await taskBase.ContinueWith(antecedent => Console.WriteLine(antecedent.Result));
        }
    }
}
