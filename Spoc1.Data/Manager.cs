using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Data
{
    public class Manager:User
    {
        public virtual Admin Admin { get; set; }

    }
}
