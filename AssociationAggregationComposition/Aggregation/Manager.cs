using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssociationAggregationComposition.Aggregation
{
    public class Manager
    {
        public List<Worker> workers = new List<Worker>();
            //new Worker("worker1"),
            //new Worker("worker2"),
            //new Worker("worker3"),
            //new Worker("worker4"),
            //};

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Manager(String n)
        {
            name = n;
        }

        public void Rule()
        {
            foreach (var w in workers)
            {
                if (workers.LastOrDefault() != null)
                    Console.Write(w.Name + ", ");
                else
                    Console.Write(w.Name);
            }
            Console.Write(" works under "+name);
        }
        
    }
}
