using Spoc1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoc1.Logic.Models
{
    public class OrderViewDTO
    {
        public int Id { get; set; }

        public string PharmacyName { get; set; }

        public string DistributorName { get; set; }

        public string AgentName { get; set; }

        public DateTime OrderDate { get; set; }

        public string BranchName { get; set; }

        public string PharmacyCode { get; set; }

        public bool ExpiryGoods { get; set; }

        public string ValueOfExpiredGoods { get; set; }

        public IEnumerable<ProductOrderDTO> Products { get; set; }

        public string ManagerName { get; set; }
    }
}
