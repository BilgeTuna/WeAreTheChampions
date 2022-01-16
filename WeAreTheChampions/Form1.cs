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
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false; //otomatik seçim
            MaclariListele();
            SonuclariKontrolEt();
            TakimlariKontrolEt();
        }

        private void MaclariListele()
        {
            var matches = db.Matches.ToList().Select(
                x => new
                {
                    MatchId = x.Id,
                    Team1 = x.Team1,
                    Team2 = x.Team2,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + " - " + x.Score2,
                    MatchResult = x.Result
                });
            dgvMatches.DataSource = matches.ToList();
        }

        private void TakimlariKontrolEt()
        {
            if (db.Teams.Any(x => x.TeamName == "Belirtilmemiş"))
            {
                return;
            }
            else
            {
                db.Teams.Add(new Team()
                {
                    TeamName = "Belirtilmemiş"
                });
                db.SaveChanges();
            }
        }

        private void SonuclariKontrolEt()
        {
            var matches = db.Matches.ToList();
            foreach (Match match in matches)
            {
                if (match.Score1 > match.Score2)
                {
                    match.Result = Models.Result.Team1;
                }
                else if (match.Score2 > match.Score1)
                {
                    match.Result = Models.Result.Team2;
                }
                else if (match.Score2 == match.Score1)
                {
                    match.Result = Models.Result.Berabere;
                }
                else
                {
                    match.Result = null;
                }
                db.SaveChanges();
            }


        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(db);
            teamsForm.ShowDialog();
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm(db);
            playersForm.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewMatchForm newMatchForm = new NewMatchForm(db);
            newMatchForm.ShowDialog();
            MaclariListele();
        }
    }
}
