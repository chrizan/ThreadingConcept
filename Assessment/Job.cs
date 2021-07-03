using System.Collections.Generic;

namespace Assessment
{
    public class Job
    {
        private int _index = 0;

        private readonly List<Operation> _operations;

        public Job(params Operation[] operations)
        {
            _operations = new List<Operation>(operations);
        }

        public Operation GetNextOperation()
        {
            if (_index == 0)
            {
                var operation = _operations[_index];
                _index++;
                return operation;
            }
            else
            {
                if (_operations.Count - 1 >= _index)
                {
                    var lastOperation = _operations[_index - 1];
                    var nextOperation = _operations[_index];
                    if (lastOperation.IsFinished)
                    {
                        _index++;
                        return nextOperation;
                    }
                }
            }
            return null;
        }

        public int? GetMachineIdForNextOperation()
        {
            if (_operations.Count - 1 >= _index)
            {
                return _operations[_index].MachineId;
            }
            else return null;
        }
    }
}
