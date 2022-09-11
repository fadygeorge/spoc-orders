using System;
using System.Collections.Generic;
using System.Text;

namespace Spoc1.Logic.Models
{
    public class ProductOrderInputDTO
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
