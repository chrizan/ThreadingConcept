using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assessment
{
    public class Scheduler
    {
        private readonly List<Job> _jobs = Infrastructure.GetJobs();

        private readonly List<Machine> _machines = Infrastructure.GetMachines();

        private readonly List<Task<int>> _machineTasks = new();

        public async Task Execute()
        {
            ScheduleOperations();
            while (_machineTasks.Count > 0)
            {
                Task<int> machineTask = await Task.WhenAny(_machineTasks);
                _machineTasks.Remove(machineTask);
                _machines[machineTask.Result].IsBusy = false;
                ScheduleOperations();
            }
        }

        private void ScheduleOperations()
        {
            foreach (var job in _jobs)
            {
                int? machineIdForNextOperation = job.GetMachineIdForNextOperation();
                if (machineIdForNextOperation.HasValue && !_machines[machineIdForNextOperation.Value].IsBusy)
                {
                    var nextOperation = job.GetNextOperation();
                    if (nextOperation != null)
                    {
                        _machines[machineIdForNextOperation.Value].IsBusy = true;
                        _machineTasks.Add(Task.Factory.StartNew(() => MachineApi.ExecuteOperation(nextOperation)));
                    }
                }
            }
        }
    }
}
