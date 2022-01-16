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

namespace WeAreTheChampions
{
    public partial class ColorsForm : Form
    {
        AppDbContext db;
        Models.Color color;

        public ColorsForm(Data.AppDbContext db2)
        {
            db = db2;
            InitializeComponent();
            ColorsList();
        }

        private void ColorsList()
        {
            lbColors.DataSource = null;
            lbColors.DataSource = db.Colors.ToList();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen renk adı giriniz");
                return;
            }
            if (btnAddColor.Text == "Add")
            {
                if (db.Colors.Any(x => x.ColorName == txtColorName.Text.Trim()))
                {
                    MessageBox.Show("Renk mevcut");
                    return;
                }
                db.Colors.Add(new Models.Color()
                {
                    ColorName = txtColorName.Text.Trim(),
                    Red = (int)nudRed.Value,
                    Green = (int)nudGreen.Value,
                    Blue = (int)nudBlue.Value
                });
            }
            else if (btnEditColor.Text == "Edit")
            {
                color.ColorName = txtColorName.Text;
                color.Blue = (int)nudBlue.Value;
                color.Red = (int)nudRed.Value;
                color.Green = (int)nudGreen.Value;
            }
            db.SaveChanges();
            ClearForm();
            ColorsList();
        }

        private void ClearForm()
        {
            btnAddColor.Text = "Add Color";
            nudGreen.Value = 0;
            nudBlue.Value = 0;
            nudRed.Value = 0;
            txtColorName.Clear();
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {
            color = (Models.Color)lbColors.SelectedItem;
            txtColorName.Text = color.ColorName;
            nudRed.Value = (decimal)color.Red;
            nudGreen.Value = (decimal)color.Green;
            nudBlue.Value = (decimal)color.Blue;
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            var delete = (Models.Color)lbColors.SelectedItem;
            db.Colors.Remove(delete);
            db.SaveChanges();
            ClearForm();
            ColorsList();
        }

        private void btnCancelEditColor_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnShowColor_Click(object sender, EventArgs e)
        {
            pbPreview.BackColor = System.Drawing.Color.FromArgb((int)nudBlue.Value, (int)nudRed.Value, (int)nudGreen.Value);
        }
    }
}
