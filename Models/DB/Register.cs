using System;
using System.Collections.Generic;
#nullable disable
namespace aviato.Models.DB
{
    public partial class Register
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullanıcıAd { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
