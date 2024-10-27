using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cast
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Gender { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string TmdbUrl { get; set; }

    }
}
