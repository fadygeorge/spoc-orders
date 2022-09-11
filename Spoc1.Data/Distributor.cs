using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace spoc1.Data
{
    public class Distributor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Agent")]
        public int? AgentId { get; set; }
        public virtual Agent Agent { get; set; }
    }
}
