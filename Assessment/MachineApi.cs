using System;
using System.Threading;

namespace Assessment
{
    public static class MachineApi
    {
        public static int ExecuteOperation(Operation operation)
        {
            Console.WriteLine(operation.StartMessage());
            Thread.Sleep(operation.DurationMs);
            operation.IsFinished = true;
            Console.WriteLine(operation.EndMessage());
            return operation.MachineId;
        }
    }
}
