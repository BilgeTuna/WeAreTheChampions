using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class TeamPlayersForm : Form
    {
        AppDbContext db;
        Team team;

        public TeamPlayersForm(Data.AppDbContext db2, Team team2)
        {
            team = team2;
            db = db2;
            InitializeComponent();
            PlayersList();
        }

        private void PlayersList()
        {
            lbPlayers.DataSource = db.Players.Where(x => x.Team.TeamName == team.TeamName).ToList();
            lbAllPlayers.DataSource = db.Players.Where(x => x.Team.TeamName != team.TeamName).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbAllPlayers.SelectedItem;
            player.Team = team;
            db.SaveChanges();
            PlayersList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbPlayers.SelectedItem;
            player.Team = db.Teams.FirstOrDefault(x => x.TeamName == "Belirtilmemiş");
            db.SaveChanges();
            PlayersList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim() == "")
            {
                PlayersList();
            }
            else
            {
                lbAllPlayers.DataSource = db.Players
                    .Where(x => x.Team.TeamName != team.TeamName && x.PlayerName
                    .Contains(txtAra.Text.Trim()))
                    .ToList();
            }
        }
    }
}
