namespace frm_Ini
{
    partial class frm_Ini
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Cer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeRoboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Inicio);
            this.panel1.Controls.Add(this.btn_Max);
            this.panel1.Controls.Add(this.btn_Min);
            this.panel1.Controls.Add(this.btn_Cer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 52);
            this.panel1.TabIndex = 0;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.Location = new System.Drawing.Point(322, 2);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(92, 40);
            this.lbl_Inicio.TabIndex = 2;
            this.lbl_Inicio.Text = "Inicio";
            // 
            // btn_Max
            // 
            this.btn_Max.BackgroundImage = global::frm_Ini.Properties.Resources._002_maximizar_la_opcion_de_tamano;
            this.btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Location = new System.Drawing.Point(685, 12);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(34, 29);
            this.btn_Max.TabIndex = 4;
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.BackgroundImage = global::frm_Ini.Properties.Resources._001_minimizar;
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(648, 12);
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
            this.btn_Cer.FlatAppearance.BorderSize = 0;
            this.btn_Cer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cer.Location = new System.Drawing.Point(725, 12);
            this.btn_Cer.Name = "btn_Cer";
            this.btn_Cer.Size = new System.Drawing.Size(34, 29);
            this.btn_Cer.TabIndex = 2;
            this.btn_Cer.UseVisualStyleBackColor = true;
            this.btn_Cer.Click += new System.EventHandler(this.btn_Cer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 61);
            this.panel3.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.reporteDeRoboToolStripMenuItem,
            this.agregarUsuarioToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(770, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 57);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.equipoToolStripMenuItem});
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 57);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // reporteDeRoboToolStripMenuItem
            // 
            this.reporteDeRoboToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reporteDeRoboToolStripMenuItem.Name = "reporteDeRoboToolStripMenuItem";
            this.reporteDeRoboToolStripMenuItem.Size = new System.Drawing.Size(104, 57);
            this.reporteDeRoboToolStripMenuItem.Text = "Reporte de robo";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(104, 57);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 57);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 57);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 57);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click_1);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // frm_Ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Ini";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Cer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeRoboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

