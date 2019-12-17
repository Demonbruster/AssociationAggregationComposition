using AssociationAggregationComposition.Aggregation;
using AssociationAggregationComposition.Association;
using System;

namespace AssociationAggregationComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            AssociationTest associationTest = new AssociationTest();
            associationTest.RunTest();

            Console.WriteLine();

            AggregationTest aggregationTest = new AggregationTest();
            aggregationTest.RunTest();


            Console.ReadLine();
        }
    }
}
