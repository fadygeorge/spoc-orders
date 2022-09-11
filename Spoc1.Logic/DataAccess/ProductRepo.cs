using spoc1.Data;
using spoc1.Data.Migrations;
using spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Logic.DataAccess
{
    public class ProductRepo : Repository<Product>
    {
        Context context;
        public ProductRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Product> Get()
        {

            return AsQueryable();

        }

        public void AddNew(Product model)
        {

            Insert(model);

        }


    }
}
