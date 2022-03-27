using System;
using System.Collections.Generic;
#nullable disable
namespace aviato.Models.DB
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
