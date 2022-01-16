using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using WeAreTheChampions.Models;
using Match = WeAreTheChampions.Models.Match;

namespace WeAreTheChampions
{
    public partial class EditMatch : Form
    {
        AppDbContext db;
        Match match;
        public EditMatch(Data.AppDbContext db2, Match match2)
        {
            db = db2;
            match = match2;
            InitializeComponent();
            Edit();
        }
        private void Edit()
        {
            cboTeam1.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            cboTeam2.DataSource = db.Teams.Where(x => x.TeamName != "Belirtilmemiş").ToList();
            DateTime dateTime = (DateTime)match.MatchTime;
            cboTeam1.SelectedItem = match.Team1;
            cboTeam2.SelectedItem = match.Team2;
            nudHour.Value = (decimal)dateTime.Hour;
            nudMinute.Value = (decimal)dateTime.Minute;
            nudMonth.Value = (decimal)dateTime.Month;
            nudDay.Value = (decimal)dateTime.Day;
            nudYear.Value = (decimal)dateTime.Year;
            nudScore1.Value = (decimal)match.Score1;
            nudScore1.Value = (decimal)match.Score2;
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (cboTeam1.SelectedIndex == -1 || cboTeam2.SelectedIndex == -1 || cboTeam2.SelectedItem == cboTeam1.SelectedItem)
            {
                MessageBox.Show("Geçerli bir seçim yapınız");
                return;
            }

            DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
            if (date < DateTime.Now)
            {
                MessageBox.Show("Geçersiz tarih");
                return;
            }
            match.Team1 = (Team)cboTeam1.SelectedItem;
            match.Team2 = (Team)cboTeam2.SelectedItem;
            match.Score1 = (int)nudScore1.Value;
            match.Score2 = (int)nudScore2.Value;
            match.MatchTime = date;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
