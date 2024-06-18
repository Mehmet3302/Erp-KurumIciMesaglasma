﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Erp___Kurum_Ici_Haberlesme_2.Models
{
    public class AppUser : IdentityUser<string>
    {
        public string? PersonelAdSoyad { get; set; }
        public string? TcKimlikNo { get; set; }
        public byte[]? ProfilResmi { get; set; }
        [Display(Name = "Resim Dosyası")]
        [NotMapped]
        public IFormFile? ProfilResmiDosyasi { get; set; }
        public bool OnlineDurumu { get; set; }
        public int BirimId { get; set; }
        public int AltBirimId { get; set; }
        public virtual AltBirimler? AltBirim { get; set; }
        public virtual ICollection<Message>? Mesajlar { get; set; }
    }
}
