using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            TeamPlayers = new HashSet<Player>();
            TeamColors = new HashSet<TeamColor>();
            Team1Matches = new HashSet<Match>();
            Team2Matches = new HashSet<Match>();
        }

        //Id
        public int Id { get; set; }

        //TeamName
        public string TeamName { get; set; }

        public virtual ICollection<Player> TeamPlayers { get; set; }

        public virtual ICollection<TeamColor> TeamColors { get; set; }

        public virtual ICollection<Match> Team1Matches { get; set; }

        public virtual ICollection<Match> Team2Matches { get; set; }

        public override string ToString()
        {
            return TeamName;
        }
    }
}
