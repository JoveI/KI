using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ArheoloskiNaog.Models
{
    public class Komentar
    {

        [Key]
        public int ID { get; set; }

        [DisplayName("Корисник")]
        public String Korisnik { get; set; }

        [DisplayName("Време")]
        public DateTime Vreme { get; set; }

        [DisplayName("Порака")]
        public String Poraka { get; set; }

        [DisplayName("Археолошки локалитет")]
        public Lokalitet Lokalitet { get; set; }
    }

    public partial class ArheologijaDBContext : DbContext
    {
        public List<Komentar> Komentari { get; set; }

        public System.Data.Entity.DbSet<Komentar> Comments { get; set; }
    }
}