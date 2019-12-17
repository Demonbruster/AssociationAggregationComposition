using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Association
{
    public class AssociationTest
    {
        Driver driver = new Driver("Driver 1");
        Vehicle vehicle = new Vehicle("Vechile 1");

        public void RunTest()
        {
            driver.Drive(vehicle);
        }
    }
}
