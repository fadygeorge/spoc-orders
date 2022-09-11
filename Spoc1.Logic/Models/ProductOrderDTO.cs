using spoc1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Spoc1.Logic.Models
{
    public class ProductOrderDTO
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }

    }
}
