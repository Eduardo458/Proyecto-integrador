namespace frm_Ini.GUI
{
    partial class frm_Ses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.lbl_Us = new System.Windows.Forms.Label();
            this.lbl_Con = new System.Windows.Forms.Label();
            this.txt_Us = new System.Windows.Forms.TextBox();
            this.txt_Con = new System.Windows.Forms.TextBox();
            this.btn_Ac = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Cer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Inicio);
            this.panel1.Controls.Add(this.btn_Min);
            this.panel1.Controls.Add(this.btn_Cer);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 52);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.Location = new System.Drawing.Point(116, 5);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(199, 40);
            this.lbl_Inicio.TabIndex = 2;
            this.lbl_Inicio.Text = "Iniciar Sesión";
            // 
            // lbl_Us
            // 
            this.lbl_Us.AutoSize = true;
            this.lbl_Us.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Us.Location = new System.Drawing.Point(3, 54);
            this.lbl_Us.Name = "lbl_Us";
            this.lbl_Us.Size = new System.Drawing.Size(114, 40);
            this.lbl_Us.TabIndex = 3;
            this.lbl_Us.Text = "Usuario";
            // 
            // lbl_Con
            // 
            this.lbl_Con.AutoSize = true;
            this.lbl_Con.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Con.Location = new System.Drawing.Point(3, 126);
            this.lbl_Con.Name = "lbl_Con";
            this.lbl_Con.Size = new System.Drawing.Size(161, 40);
            this.lbl_Con.TabIndex = 4;
            this.lbl_Con.Text = "Contraseña";
            // 
            // txt_Us
            // 
            this.txt_Us.Location = new System.Drawing.Point(10, 97);
            this.txt_Us.Name = "txt_Us";
            this.txt_Us.Size = new System.Drawing.Size(367, 20);
            this.txt_Us.TabIndex = 5;
            // 
            // txt_Con
            // 
            this.txt_Con.HideSelection = false;
            this.txt_Con.Location = new System.Drawing.Point(10, 169);
            this.txt_Con.Name = "txt_Con";
            this.txt_Con.PasswordChar = '*';
            this.txt_Con.Size = new System.Drawing.Size(367, 20);
            this.txt_Con.TabIndex = 6;
            // 
            // btn_Ac
            // 
            this.btn_Ac.BackColor = System.Drawing.Color.Silver;
            this.btn_Ac.FlatAppearance.BorderSize = 0;
            this.btn_Ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ac.Location = new System.Drawing.Point(12, 210);
            this.btn_Ac.Name = "btn_Ac";
            this.btn_Ac.Size = new System.Drawing.Size(112, 36);
            this.btn_Ac.TabIndex = 7;
            this.btn_Ac.Text = "Acceder";
            this.btn_Ac.UseVisualStyleBackColor = false;
            this.btn_Ac.Click += new System.EventHandler(this.btn_Ac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::frm_Ini.Properties.Resources.LogoUTM;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Min
            // 
            this.btn_Min.BackgroundImage = global::frm_Ini.Properties.Resources._001_minimizar;
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(321, 13);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(31, 29);
            this.btn_Min.TabIndex = 3;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Cer
            // 
            this.btn_Cer.BackgroundImage = global::frm_Ini.Properties.Resources._003_error;
            this.btn_Cer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cer.FlatAppearance.BorderSize = 0;
            this.btn_Cer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cer.Location = new System.Drawing.Point(358, 13);
            this.btn_Cer.Name = "btn_Cer";
            this.btn_Cer.Size = new System.Drawing.Size(34, 29);
            this.btn_Cer.TabIndex = 2;
            this.btn_Cer.UseVisualStyleBackColor = true;
            this.btn_Cer.Click += new System.EventHandler(this.btn_Cer_Click);
            // 
            // frm_Ses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 269);
            this.Controls.Add(this.btn_Ac);
            this.Controls.Add(this.txt_Con);
            this.Controls.Add(this.txt_Us);
            this.Controls.Add(this.lbl_Con);
            this.Controls.Add(this.lbl_Us);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Ses";
            this.Text = "Iniciar_Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Cer;
        private System.Windows.Forms.Label lbl_Us;
        private System.Windows.Forms.Label lbl_Con;
        private System.Windows.Forms.TextBox txt_Us;
        private System.Windows.Forms.TextBox txt_Con;
        private System.Windows.Forms.Button btn_Ac;
    }
}