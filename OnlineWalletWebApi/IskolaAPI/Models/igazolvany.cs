using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IskolaAPI.Models
{
    public partial class igazolvany
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string documentId { get; set; }
        [Required]
        [StringLength(255)]
        public string fullname { get; set; }
        [Required]
        [StringLength(255)]
        public string gender { get; set; }
        [Required]
        [StringLength(255)]
        public string year { get; set; }
        [Required]
        [StringLength(255)]
        public string month { get; set; }
        [Required]
        [StringLength(255)]
        public string day { get; set; }
    }
}
