using Spoc1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace spoc1.Data
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string BranchName { get; set; }

        public string PharmacyCode { get; set; }

        public bool ExpiryGoods { get; set; }

        public string ValueOfExpiredGoods { get; set; }

        public virtual ICollection<ProductOrder> Products { get; set; }

        [ForeignKey("Agent")]
        public int AgentId { get; set; }
        public virtual Agent Agent { get; set; }

        [ForeignKey("Pharmacy")]
        public int PharmacyId { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }

        [ForeignKey("Distributor")]
        public int DistributorId { get; set; }
        public virtual Distributor Distributor { get; set; }

        


    }
}
