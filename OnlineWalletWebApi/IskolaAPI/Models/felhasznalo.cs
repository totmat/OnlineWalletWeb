using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IskolaAPI.Models
{
    public partial class felhasznalo
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string fullname { get; set; }
        [Required]
        [StringLength(100)]
        public string email { get; set; }
        [Required]
        [StringLength(100)]
        public string username { get; set; }
        [Required]
        [StringLength(100)]
        public string password { get; set; }
    }
}
