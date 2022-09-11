using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class AgentRepo : Repository<Agent>
    {
        Context context;
        public AgentRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Agent> Get()
        {
            
            return AsQueryable();
        }

        public Agent Get(int id)
        {
            
            return AsQueryable().Where(w => w.Id == id).FirstOrDefault();
        }

        public Agent Get(string email)
        {
            
            return AsQueryable().Where(w => w.Email == email).FirstOrDefault();
        }

        public void Add(Agent model)
        {
           
            Insert(model);
        }

        public void Edit(Agent model)
        {
            
            Update(model);
        }

        public void Delete(int id)
        {

            var data = AsQueryable().Where(w => w.Id == id).FirstOrDefault();

            Delete(data);
        }
    }
}
