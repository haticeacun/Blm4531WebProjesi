using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; } 
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; } //1e cok iliskiyi sagladı.Bir blogun birden fazla yorumu olabilir ama bir yorumun birden fazla blogu olamaz.
    }
}