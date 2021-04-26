using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Models
{
    public class MovieViewModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(20)]
        public string Genre { get; set; }

        public double Runtime { get; set; }
    }
}
