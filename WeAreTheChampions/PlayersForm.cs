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
    public partial class PlayersForm : Form
    {
        AppDbContext db;
        public PlayersForm(Data.AppDbContext db2)
        {
            db = db2;
            InitializeComponent();
            dgvPlayers.AutoGenerateColumns = false;
            cboTeams.DataSource = db.Teams.ToList();
            ClearForm();
            PlayerList();
        }

        private void PlayerList()
        {
            dgvPlayers.DataSource = null;
            dgvPlayers.DataSource = db.Players.ToList();
        }

        private void ClearForm()
        {
            cboTeams.SelectedIndex = 0;
            txtPlayerName.Clear();
            btnAddPlayer.Text = "Add Player";
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player player;
            if (txtPlayerName.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen oyuncu adı oluşturun");
                return;
            }
            if (btnAddPlayer.Text == "Add Player")
            {
                player = new Player();
                PlayerDurum(player);
                db.Players.Add(player);
            }
            else if (btnAddPlayer.Text == "Edit Player")
            {
                player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
                PlayerDurum(player);
            }
            db.SaveChanges();
            ClearForm();
            PlayerList();
        }

        private void PlayerDurum(Player player)
        {
            player.PlayerName = txtPlayerName.Text.Trim();
            if (cboTeams.SelectedIndex != -1)
            {
                player.Team = (Team)cboTeams.SelectedItem;
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            txtPlayerName.Text = player.PlayerName;
            cboTeams.SelectedItem = player.Team;
            btnCancelEdit.Visible = true;
            dgvPlayers.Enabled = false;
            btnAddPlayer.Text = "Edit Player";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                PlayerList();
            }
            else
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.Team.TeamName.Contains(txtSearch.Text.Trim())).ToList();
            }
        }
    }
}
