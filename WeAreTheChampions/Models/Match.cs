using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Matches")]
    public class Match
    {
        //Id
        public int Id { get; set; }

        //MatchTime
        public DateTime? MatchTime { get; set; }

        //Team1Id(Zorunlu)
        [Required]
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }

        //Team2Id(Zorunlu)
        [Required]
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }

        //Scroe1
        public int Score1 { get; set; }

        //Scroe2
        public int Score2 { get; set; }

        //Result(NULL: belli değil, 0: berabere, 1: Team1 kazandı, Team2 kazandı)
        public  Result? Result { get; set; }
    }
}
