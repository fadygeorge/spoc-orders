using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class DistributorRepo : Repository<Distributor>
    {
        Context context;
        public DistributorRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Distributor> Get(int AgentId)
        {
            return AsQueryable().Where(w => w.AgentId == AgentId);
        }

        public void Add(Distributor model)
        {

            Insert(model);

        }
    }
}
