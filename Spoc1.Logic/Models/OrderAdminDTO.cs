using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic.Models
{
    public class OrderAdminDTO
    {
        public int Id { get; set; }
        public string PharmacyName { get; set; }

        public string AgentName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
