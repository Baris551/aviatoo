using System;
using System.Collections.Generic;
#nullable disable
namespace aviato.Models.DB
{
    public partial class Trend
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
