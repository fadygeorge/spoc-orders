using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace spoc1.Data
{
    public class Pharmacy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [ForeignKey("Agent")]
        public int? AgentId { get; set; }
        public virtual Agent Agent { get; set; }

    }
}
