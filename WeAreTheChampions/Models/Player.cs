using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class Player
    {
        //Id
        public int Id { get; set; }

        //TeamId
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        //PlayerName
        [Required]
        public string PlayerName { get; set; }

        public override string ToString()
        {
            return PlayerName;
        }
        
        
    }
}
