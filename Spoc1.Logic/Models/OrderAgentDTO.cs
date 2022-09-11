using spoc1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic.Models
{
    public class OrderAgentDTO
    {
        public int Id { get; set; }
        public string PharmacyName { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
