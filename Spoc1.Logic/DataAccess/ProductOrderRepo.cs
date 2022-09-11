using spoc1.Data;
using spoc1.Logic.Models;
using Spoc1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoc1.Logic.DataAccess
{
    public class ProductOrderRepo : Repository<ProductOrder>
    {
        Context context;
        public ProductOrderRepo(Context context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<ProductOrder> Get(int orderId)
        {

            return AsQueryable().Where(w => w.OrderId == orderId);

        }

        

    }
}
