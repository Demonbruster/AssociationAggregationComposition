using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationAggregationComposition.Composition
{
    public class Project
    {
        private Manager manager;
        public Boolean isSuccess = false;

        public Project(Manager manager)
        {
            this.manager = manager;
        }

        public bool Issuccess
        {
            get { return Issuccess; }
            set { Issuccess = value;
                if (value)
                    this.manager.salary++;  
                else
                    this.manager.salary--;
            }
        }
    }
}
