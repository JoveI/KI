using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ArheoloskiNaog.Models
{
    public class Lokalitet
    {

        [Key]
        public int ID { get; set; }

        [DisplayName("Име")]
        public string Ime { get; set; }

        [DisplayName("Област")]
        public string Oblast { get; set; }

        [DisplayName("Период")]
        public string Period { get; set; }

        [DisplayName("Период во годнини")]
        public string PeriodGodini { get; set; }

        [DisplayName("Детали")]
        public string Detali { get; set; }

        [DisplayName("Влез")]
        public string Vlez { get; set; }

        public string ImageUrl { get; set; }

        public string Galery { get; set; }

        [DisplayName("Опис")]
        public string Opis { get; set; }
    }

    public partial class ArheologijaDBContext : DbContext
    {
        public List<Lokalitet> Lokaliteti { get; set; }

        public System.Data.Entity.DbSet<Lokalitet> Localities { get; set; }
    }
}