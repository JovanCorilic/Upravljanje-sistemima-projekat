using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Director
    {
        public Director()
        {
        }

        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Niz mora biti od 5 do 50")]
        public string Name { get; set; }
        [Required]
        [RangeAttribute(0,double.PositiveInfinity)]
        public int Oscars { get; set; }
        [Required]
        public string Born { get; set; }
        public string Died { get; set; }

        public virtual List<Movie> Movies { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Oscars} {Born} {Died}";
        }
    }
}
