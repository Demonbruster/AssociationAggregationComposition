using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Composition
{
    public class Manager
    {
        public Project project;

        public double salary;

        private string name;
        
        public string Name
        {
            get { return name; }
        }

        public Manager(string n, double s)
        {
            name = n;
            salary = s;
        }

        public Manager()
        {
            project = new Project(this);
        }

        public void HowIsTheManager(bool good)
        {
            if (good)
                project.Issuccess = true;
            else
                project.Issuccess = false;
        }
    }
}
