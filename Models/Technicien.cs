using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeeEauTest2.Models
{
    public partial class Technicien
    {
        public Technicien()
        {
            Epci = new HashSet<Epci>();
        }

        [Key]
        public int IdTechnicien { get; set; }
        [Required]
        [StringLength(250)]
        public string Nom { get; set; }
        [Required]
        [StringLength(250)]
        public string Prenom { get; set; }
        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [InverseProperty("FkIdTechnicienNavigation")]
        public virtual ICollection<Epci> Epci { get; set; }
    }
}