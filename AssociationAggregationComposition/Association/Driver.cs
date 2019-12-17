using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Association
{
    public class Driver
    {
        private string name;

        public Driver()
        {

        }
        public Driver(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        public void Drive(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetName()+" Drive By "+name);
        }
    }
}
