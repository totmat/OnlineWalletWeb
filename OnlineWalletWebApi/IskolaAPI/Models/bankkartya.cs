using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IskolaAPI.Models
{
    public partial class bankkartya
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int cardNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string date { get; set; }
        [Required]
        [StringLength(255)]
        public string securityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string firstName { get; set; }
        [Required]
        [StringLength(255)]
        public string lastName { get; set; }
    }
}
