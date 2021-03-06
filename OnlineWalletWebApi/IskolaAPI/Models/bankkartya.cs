using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace OnlineWalletAPI.Models
{
    public partial class bankkartya
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string cardNumber { get; set; }
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
