using spoc1.Data;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class AdminRepo : Repository<Admin>
    {
        Context context;
        public AdminRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Admin> Get()
        {
            return AsQueryable();
        }

        public Admin Get(int id)
        {

            return AsQueryable().Where(w => w.Id == id).FirstOrDefault();
        }

        public Admin Get(string email)
        {
       
            return AsQueryable().Where(w => w.Email == email).FirstOrDefault();
        }

        public void Add(Admin model)
        {
            
            Insert(model);

        }

        public void Edit(Admin model)
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
