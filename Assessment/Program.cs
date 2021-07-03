using System;

namespace Assessment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started...");
            var startTime = DateTime.Now;
            var scheduler = new Scheduler();
            scheduler.Execute().GetAwaiter().GetResult();
            Console.WriteLine($"Program finished after {DateTime.Now - startTime} seconds.");
        }
    }
}
