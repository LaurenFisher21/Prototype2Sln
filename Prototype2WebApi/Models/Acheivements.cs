﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Acheivements
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AcheivemesntsId { get; set; }
        public string Descriptions { get; set; }
    }
}