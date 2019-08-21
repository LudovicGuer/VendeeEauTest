using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendeeEauTest2.Models
{
    public partial class ConseilLocal
    {
        [Key]
        public int IdConseilLocal { get; set; }
        [Required]
        [StringLength(250)]
        public string NomConseilLocal { get; set; }
    }
}