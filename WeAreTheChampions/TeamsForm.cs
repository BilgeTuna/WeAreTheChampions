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
    public partial class TeamsForm : Form
    {
        AppDbContext db;
        Team teamEdit;

        public TeamsForm(Data.AppDbContext db2)
        {
            db = db2;
            InitializeComponent();
            TeamsList();
            cboColors.DataSource = db.Colors.ToList();
        }

        private void TeamsList()
        {
            lbTeams.DataSource = null;
            lbTeams.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var duzenle = (Team)lbTeams.SelectedItem;
            Models.Color color = (Models.Color)cboColors.SelectedItem;
            if (teamEdit.TeamColors.Any(x => x.ColorId == color.Id))
            {
                MessageBox.Show("Renk mevcut");
            }
            teamEdit.TeamColors.Add(new TeamColor()
            {
                Team = teamEdit,
                Color = (Models.Color)cboColors.SelectedItem
            });

            db.SaveChanges();
            cboColors.SelectedIndex = -1;
            lbColors.DataSource = null;
            lbColors.DataSource = duzenle.TeamColors.ToList();
        }

        private void ClearForm()
        {
            lbColors.Enabled = false;
            cboColors.Enabled = false;
            btnAddColor.Enabled = false;
            btnDelete.Enabled = false;
            btnAddTeam.Text = "Team";
            btnCancelEdit.Visible = false;
            txtTeamName.Clear();
            lbColors.DataSource = null;
            for (int i = 0; i < lbColors.Items.Count; i++)
            {
                lbColors.Items.RemoveAt(i);
            }
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            ClearForm();
            if (lbTeams.SelectedItem != null)
            {

                lbTeams.Enabled = false;
                lbColors.Enabled = true;
                cboColors.Enabled = true;
                btnAddColor.Enabled = true;
                btnDelete.Enabled = true;
                btnAddTeam.Text = "Edit Team";
                teamEdit = (Team)lbTeams.SelectedItem;
                txtTeamName.Text = teamEdit.TeamName;
                foreach (var item in db.TeamColors)
                {
                    if (item.TeamId == teamEdit.Id)
                    {
                        lbColors.Items.Add(item);
                    }
                }
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearForm();
            for (int i = 0; i < lbColors.Items.Count; i++)
            {
                lbColors.Items.RemoveAt(i);
            }
            lbTeams.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = (Team)lbTeams.SelectedItem;
            if (delete.TeamPlayers.Count > 0)
            {
                MessageBox.Show("Takımda oyuncular mevcut. Lütfen oyuncuları transfer edin");
                return;
            }
            if (db.Matches.Any(x => x.Team1.Id == delete.Id) || db.Matches.Any(x => x.Team2.Id == delete.Id))
            {
                MessageBox.Show("Seçili takımın mamçı bulunmaktadır.Maç iptali Yapınız");
                return;
            }
            db.Teams.Remove(delete);
            db.SaveChanges();
            TeamsList();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text.Trim() == "")
            {
                MessageBox.Show("LÜtfen takım adı giriniz");
                return;
            }
            if (btnAddTeam.Text == "Team")
            {
                if (db.Teams.Any(x => x.TeamName == txtTeamName.Text.Trim()))
                {
                    MessageBox.Show("Takım adı kullanılmaktadır");
                    return;
                }
                db.Teams.Add(new Team
                {
                    TeamName = txtTeamName.Text.Trim()
                });
                db.SaveChanges();
                ClearForm();
                TeamsList();
            }
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            var team = (Team)lbTeams.SelectedItem;
            TeamColor deleteColor = (TeamColor)lbColors.SelectedItem;
            team.TeamColors.Remove(deleteColor);
            lbColors.DataSource = team.TeamColors.ToList();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir takım seçin");
                return;
            }
            Team team = (Team)lbTeams.SelectedItem;
            TeamPlayersForm frmTeamPlayers = new TeamPlayersForm(db, team);
            frmTeamPlayers.ShowDialog();
        }
    }
}
