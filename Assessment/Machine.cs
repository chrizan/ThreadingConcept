namespace Assessment
{
    public class Machine
    {
        public Machine(int machineId)
        {
            MachineId = machineId;
            IsBusy = false;
        }

        public int MachineId { get; private set; }

        public bool IsBusy { get; set; }
    }
}
