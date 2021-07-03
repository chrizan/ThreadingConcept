namespace Assessment
{
    public class Operation
    {
        public Operation(int jobId, int operationId, int machineId, int durationMs)
        {
            MachineId = machineId;
            DurationMs = durationMs;
            JobId = jobId;
            OperationId = operationId;
            IsFinished = false;
        }

        public int MachineId { get; private set; }

        public int DurationMs { get; private set; }

        public bool IsFinished { get; set; }

        private int JobId { get; set; }

        private int OperationId { get; set; }

        public string StartMessage()
        {
            return $"Operation {OperationId} of job {JobId} has started on machine {MachineId}.";
        }

        public string EndMessage()
        {
            return $"Operation {OperationId} of job {JobId} is finished on machine {MachineId}.";
        }
    }
}
