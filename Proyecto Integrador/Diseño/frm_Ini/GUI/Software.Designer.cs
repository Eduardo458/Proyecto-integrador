﻿namespace frm_Ini.GUI
{
    partial class frm_Eq
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
            this.grb_B = new System.Windows.Forms.GroupBox();
            this.lbl_Bus = new System.Windows.Forms.Label();
            this.btn_Bus = new System.Windows.Forms.Button();
            this.txt_Vers = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Mod = new System.Windows.Forms.Label();
            this.lbl_Ser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Cer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_B.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_B
            // 
            this.grb_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_B.Controls.Add(this.lbl_Bus);
            this.grb_B.Controls.Add(this.btn_Bus);
            this.grb_B.Controls.Add(this.txt_Vers);
            this.grb_B.Controls.Add(this.txt_Nom);
            this.grb_B.Controls.Add(this.lbl_Mod);
            this.grb_B.Controls.Add(this.lbl_Ser);
            this.grb_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_B.Location = new System.Drawing.Point(162, 80);
            this.grb_B.Name = "grb_B";
            this.grb_B.Size = new System.Drawing.Size(265, 158);
            this.grb_B.TabIndex = 12;
            this.grb_B.TabStop = false;
            // 
            // lbl_Bus
            // 
            this.lbl_Bus.AutoSize = true;
            this.lbl_Bus.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bus.Location = new System.Drawing.Point(87, 16);
            this.lbl_Bus.Name = "lbl_Bus";
            this.lbl_Bus.Size = new System.Drawing.Size(100, 40);
            this.lbl_Bus.TabIndex = 5;
            this.lbl_Bus.Text = "Buscar";
            // 
            // btn_Bus
            // 
            this.btn_Bus.BackColor = System.Drawing.Color.Silver;
            this.btn_Bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bus.FlatAppearance.BorderSize = 0;
            this.btn_Bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bus.Location = new System.Drawing.Point(82, 131);
            this.btn_Bus.Name = "btn_Bus";
            this.btn_Bus.Size = new System.Drawing.Size(110, 21);
            this.btn_Bus.TabIndex = 4;
            this.btn_Bus.Text = "Buscar";
            this.btn_Bus.UseVisualStyleBackColor = false;
            // 
            // txt_Vers
            // 
            this.txt_Vers.Location = new System.Drawing.Point(125, 98);
            this.txt_Vers.Name = "txt_Vers";
            this.txt_Vers.Size = new System.Drawing.Size(85, 20);
            this.txt_Vers.TabIndex = 3;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(125, 69);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(85, 20);
            this.txt_Nom.TabIndex = 2;
            // 
            // lbl_Mod
            // 
            this.lbl_Mod.AutoSize = true;
            this.lbl_Mod.Location = new System.Drawing.Point(55, 101);
            this.lbl_Mod.Name = "lbl_Mod";
            this.lbl_Mod.Size = new System.Drawing.Size(42, 13);
            this.lbl_Mod.TabIndex = 1;
            this.lbl_Mod.Text = "Modelo";
            // 
            // lbl_Ser
            // 
            this.lbl_Ser.AutoSize = true;
            this.lbl_Ser.Location = new System.Drawing.Point(52, 72);
            this.lbl_Ser.Name = "lbl_Ser";
            this.lbl_Ser.Size = new System.Drawing.Size(31, 13);
            this.lbl_Ser.TabIndex = 0;
            this.lbl_Ser.Text = "Serie";
            this.lbl_Ser.Click += new System.EventHandler(this.lbl_Nom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Inicio);
            this.panel1.Controls.Add(this.btn_Min);
            this.panel1.Controls.Add(this.btn_Cer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 52);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frm_Ini.Properties.Resources.LogoUTM;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.Location = new System.Drawing.Point(214, 9);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(141, 40);
            this.lbl_Inicio.TabIndex = 2;
            this.lbl_Inicio.Text = "Software";
            // 
            // btn_Min
            // 
            this.btn_Min.BackgroundImage = global::frm_Ini.Properties.Resources._001_minimizar;
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(519, 12);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(31, 29);
            this.btn_Min.TabIndex = 3;
            this.btn_Min.UseVisualStyleBackColor = true;
            // 
            // btn_Cer
            // 
            this.btn_Cer.BackgroundImage = global::frm_Ini.Properties.Resources._003_error;
            this.btn_Cer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cer.FlatAppearance.BorderSize = 0;
            this.btn_Cer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cer.Location = new System.Drawing.Point(556, 12);
            this.btn_Cer.Name = "btn_Cer";
            this.btn_Cer.Size = new System.Drawing.Size(34, 29);
            this.btn_Cer.TabIndex = 2;
            this.btn_Cer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.mod,
            this.serie,
            this.tipo});
            this.dataGridView1.Location = new System.Drawing.Point(1, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(595, 230);
            this.dataGridView1.TabIndex = 13;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            // 
            // mod
            // 
            this.mod.HeaderText = "Modelo";
            this.mod.Name = "mod";
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // frm_Eq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grb_B);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Eq";
            this.grb_B.ResumeLayout(false);
            this.grb_B.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_B;
        private System.Windows.Forms.Label lbl_Bus;
        private System.Windows.Forms.Button btn_Bus;
        private System.Windows.Forms.TextBox txt_Vers;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_Mod;
        private System.Windows.Forms.Label lbl_Ser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Cer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}