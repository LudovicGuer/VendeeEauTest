using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeeEauTest2.Models
{
    [Table("EPCI")]
    public partial class Epci
    {
        [Key]
        public int IdEpci { get; set; }
        [Required]
        [Column("EPCI")]
        [StringLength(250)]
        public string Epci1 { get; set; }
        [Required]
        [StringLength(250)]
        public string NomSecteur { get; set; }
        public int FkIdTechnicien { get; set; }

        [ForeignKey("FkIdTechnicien")]
        [InverseProperty("Epci")]
        public virtual Technicien FkIdTechnicienNavigation { get; set; }
    }
}