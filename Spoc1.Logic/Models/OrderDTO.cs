using spoc1.Data;
using Spoc1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic.Models
{
    public class OrderDTO
    {
        public OrderDTO()
        {
            Products = new HashSet<ProductOrder>();
        }
        public int Id { get; set; }

        public string PharmacyName  { get; set; }

        public string DistributorName { get; set; }

        public string AgentName { get; set; }

        public DateTime OrderDate { get; set; }

        public string BranchName { get; set; }

        public string PharmacyCode { get; set; }

        public bool ExpiryGoods { get; set; }

        public string ValueOfExpiredGoods { get; set; }

        public IEnumerable<ProductOrder> Products { get; set; }
    }
}
