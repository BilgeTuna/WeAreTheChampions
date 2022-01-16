using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Colors")]
    public class Color
    { 
        //Id
        public int Id { get; set; }

        //ColorName
        public string ColorName { get; set; }

        //Red(0-255)
        [Required, Range(0, 255)]
        public int Red { get; set; }

        //Green(0-255)
        [Required, Range(0, 255)]
        public int Green { get; set; }

        //Blue(0-255)
        [Required, Range(0, 255)]
        public int Blue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }
}
