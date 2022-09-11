using spoc1.Data;
using Spoc1.Data;
using Spoc1.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic.Models
{
    public class AddOrderDTO
    {
        public int PharmacyID { get; set; }

        public int DistributorID { get; set; }

        public int AgentID  { get; set; }

        public string BranchName { get; set; }

        public string PharmacyCode { get; set; }

        public bool ExpiryGoods { get; set; }

        public string ValueOfExpiredGoods { get; set; }

        public ICollection<ProductOrderInputDTO> Products { get; set; }

    }
}
