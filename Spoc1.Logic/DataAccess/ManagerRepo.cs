using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class ManagerRepo : Repository<Manager>
    {
        Context context;
        public ManagerRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Manager> Get()
        {
            
            return AsQueryable();
        }

        public Manager Get(int id)
        {
            
            return AsQueryable().Where(w => w.Id == id).FirstOrDefault();
        }

        public Manager Get(string email)
        {
            
            return AsQueryable().Where(w => w.Email == email).FirstOrDefault();
        }

        public void Add(Manager model)
        {
            
            Insert(model);
        }

        

        public void Edit(Manager model)
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
