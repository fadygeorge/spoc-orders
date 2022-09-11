using System;
using System.Collections.Generic;
using System.Text;

namespace spoc1.Logic.Models
{
    public class ResultDTO
    {
        public bool IsSuccess { get; set; }

        public string Token { get; set; }

        public object Data { get; set; }
    
    }
}
