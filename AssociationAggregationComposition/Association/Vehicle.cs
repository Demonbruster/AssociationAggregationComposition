using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Association
{
    public class Vehicle
    {
        private string name;

        public Vehicle()
        {

        }

        public Vehicle(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        } 

        public void DriveCar(Driver driver)
        {
            driver.Drive(this);
        }
    }
}
