using System;
using System.Collections.Generic;
#nullable disable
namespace aviato.Models.DB
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public bool? Aktif { get; set; }
        public string Image { get; set; }
    }
}
