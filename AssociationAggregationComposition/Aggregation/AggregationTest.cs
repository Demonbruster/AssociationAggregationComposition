using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Aggregation
{
    public class AggregationTest
    {
        Manager manager = new Manager("Manager 1");

        Worker worker1 = new Worker("Worker 1");
        Worker worker2 = new Worker("Worker 2");
        Worker worker3 = new Worker("Worker 3");
        Worker worker4 = new Worker("Worker 4");

        

        public void RunTest()
        {
            manager.workers.Add(worker1);
            manager.workers.Add(worker2);
            manager.workers.Add(worker3);
            manager.workers.Add(worker4);
            manager.Rule();
            Console.WriteLine();
        }
    }
}
