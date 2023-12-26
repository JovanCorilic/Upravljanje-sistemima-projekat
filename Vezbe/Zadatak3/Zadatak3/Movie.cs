using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Movie
    {
        public Movie()
        {
        }

        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3,ErrorMessage ="Koristiti 3-100 karaktera")]
        public string Title { get; set; }
        [Required]
        [RangeAttribute(typeof(double),"0","10")]
        public double Rating { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [RangeAttribute(0,double.PositiveInfinity)]
        public int Oscars { get; set; }
        [Required]
        [ForeignKey("Director")]
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Rating} {Year} {Oscars} {DirectorId}";
        }

    }
}
