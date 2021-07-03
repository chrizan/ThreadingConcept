using System.Collections.Generic;

namespace Assessment
{
    public static class Infrastructure
    {
        public static List<Job> GetJobs()
        {
            return new List<Job>()
            {
                new Job
                (
                    new Operation(1, 1, 0, 1000),
                    new Operation(1, 2, 2, 3000),
                    new Operation(1, 3, 1, 2000),
                    new Operation(1, 4, 3, 4000)
                ),
                new Job
                (
                    new Operation(2, 1, 3, 4000),
                    new Operation(2, 2, 2, 3000),
                    new Operation(2, 3, 1, 2000)
                ),
                new Job
                (
                    new Operation(3, 1, 1, 2000),
                    new Operation(3, 2, 2, 3000)
                ),
                new Job
                (
                    new Operation(4, 1, 3, 4000)
                ),
                new Job
                (
                    new Operation(5, 1, 0, 1000),
                    new Operation(5, 2, 1, 2000),
                    new Operation(5, 3, 2, 3000),
                    new Operation(5, 4, 3, 4000)
                ),
            };
        }

        public static List<Machine> GetMachines()
        {
            return new List<Machine>()
            {
                new Machine(0),
                new Machine(1),
                new Machine(2),
                new Machine(3)
            };
        }
    }
}
