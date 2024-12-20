﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string? Name { get; set; }
    }
}
