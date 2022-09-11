using Microsoft.EntityFrameworkCore;
using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class PharmacyRepo : Repository<Pharmacy>
    {
        Context context;
        public PharmacyRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Pharmacy> Get(int AgentId)
        {
            return AsQueryable().Where(w=>w.AgentId == AgentId);
        }

        public void Add(Pharmacy model)
        {

            Insert(model);

        }
    }
}
