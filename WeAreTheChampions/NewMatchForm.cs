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
    public partial class NewMatchForm : Form
    {
        AppDbContext db;
        public NewMatchForm(Data.AppDbContext db2)
        {
            db = db2;

            InitializeComponent();

            cboTeam1.SelectedIndex = -1;
            cboTeam2.SelectedIndex = -1;
            cboTeam1.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            cboTeam2.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (cboTeam1.SelectedIndex == -1 || cboTeam2.SelectedIndex == -1 || cboTeam2.SelectedItem == cboTeam1.SelectedItem)
            {
                MessageBox.Show("Lütfen doğru seçim yapın");
            }
            else
            {
                DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);

                Match gamex = new Match();
                gamex.MatchTime = date;
                gamex.Team1 = (Team)cboTeam1.SelectedItem;
                gamex.Team2 = (Team)cboTeam2.SelectedItem;
                if (nudHomeScore.Visible == true)
                {
                    gamex.Score1 = (int)nudHomeScore.Value;
                    gamex.Score2 = (int)nudAwayScore.Value;
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            nudHomeScore.Visible = true;
            nudAwayScore.Visible = true;
        }
    }
}
