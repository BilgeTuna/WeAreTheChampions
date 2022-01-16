
namespace WeAreTheChampions
{
    partial class ColorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnEditColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.btnCancelEditColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColor.Location = new System.Drawing.Point(24, 408);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(278, 50);
            this.btnDeleteColor.TabIndex = 30;
            this.btnDeleteColor.Text = "Delete";
            this.btnDeleteColor.UseVisualStyleBackColor = false;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // btnEditColor
            // 
            this.btnEditColor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditColor.Location = new System.Drawing.Point(24, 340);
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(278, 47);
            this.btnEditColor.TabIndex = 29;
            this.btnEditColor.Text = "Edit";
            this.btnEditColor.UseVisualStyleBackColor = false;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.btnShowColor);
            this.groupBox1.Controls.Add(this.btnCancelEditColor);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Controls.Add(this.nudBlue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtColorName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(324, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 398);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Color";
            // 
            // btnShowColor
            // 
            this.btnShowColor.BackColor = System.Drawing.Color.Transparent;
            this.btnShowColor.Location = new System.Drawing.Point(213, 251);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(160, 43);
            this.btnShowColor.TabIndex = 15;
            this.btnShowColor.Text = "Show Color";
            this.btnShowColor.UseVisualStyleBackColor = false;
            this.btnShowColor.Click += new System.EventHandler(this.btnShowColor_Click);
            // 
            // btnCancelEditColor
            // 
            this.btnCancelEditColor.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEditColor.Location = new System.Drawing.Point(200, 320);
            this.btnCancelEditColor.Name = "btnCancelEditColor";
            this.btnCancelEditColor.Size = new System.Drawing.Size(173, 42);
            this.btnCancelEditColor.TabIndex = 14;
            this.btnCancelEditColor.Text = "Cancel";
            this.btnCancelEditColor.UseVisualStyleBackColor = false;
            this.btnCancelEditColor.Visible = false;
            this.btnCancelEditColor.Click += new System.EventHandler(this.btnCancelEditColor_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddColor.Location = new System.Drawing.Point(6, 320);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(167, 42);
            this.btnAddColor.TabIndex = 13;
            this.btnAddColor.Text = "Add";
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbPreview.Location = new System.Drawing.Point(213, 55);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(160, 168);
            this.pbPreview.TabIndex = 11;
            this.pbPreview.TabStop = false;
            // 
            // nudBlue
            // 
            this.nudBlue.BackColor = System.Drawing.Color.White;
            this.nudBlue.Location = new System.Drawing.Point(18, 262);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(128, 32);
            this.nudBlue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blue:";
            // 
            // nudGreen
            // 
            this.nudGreen.BackColor = System.Drawing.Color.White;
            this.nudGreen.Location = new System.Drawing.Point(18, 194);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(128, 32);
            this.nudGreen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green:";
            // 
            // nudRed
            // 
            this.nudRed.BackColor = System.Drawing.Color.White;
            this.nudRed.Location = new System.Drawing.Point(18, 124);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(128, 32);
            this.nudRed.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red:";
            // 
            // txtColorName
            // 
            this.txtColorName.BackColor = System.Drawing.Color.White;
            this.txtColorName.Location = new System.Drawing.Point(10, 56);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(136, 32);
            this.txtColorName.TabIndex = 4;
            // 
            // lbColors
            // 
            this.lbColors.BackColor = System.Drawing.Color.Bisque;
            this.lbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 26;
            this.lbColors.Location = new System.Drawing.Point(24, 42);
            this.lbColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(278, 290);
            this.lbColors.TabIndex = 26;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(1009F, 1956F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(785, 488);
            this.Controls.Add(this.btnDeleteColor);
            this.Controls.Add(this.btnEditColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbColors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(360, 270, 360, 270);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.Button btnCancelEditColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.ListBox lbColors;
    }
}