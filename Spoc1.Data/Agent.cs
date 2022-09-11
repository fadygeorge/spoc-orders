using System;
using System.Collections.Generic;

namespace spoc1.Data
{
    public class Agent:User
    {
        public string Area { get; set; }

        public virtual Manager Manager { get; set; }
        
        //public ICollection<Distributor> Distributors { get; set; }

        //public ICollection<Pharmacy> Pharmacies { get; set; }

    }
}
