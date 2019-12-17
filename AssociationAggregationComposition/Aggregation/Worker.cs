using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Aggregation
{
    public class Worker
    {
        private string name;

        public string Name
        {
            get { return name; }
        }


        public Worker(string n)
        {
            name = n;
        }

    }
}
