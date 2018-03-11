using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_Ini.GUI;

namespace frm_Ini
{
    public partial class frm_Ini : Form
    {
        public frm_Ini()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_Cer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sal_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Ses_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Ag_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ini v1 = new frm_Ini();
            v1.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Inv_Soft v1 = new frm_Inv_Soft();
            v1.Show();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ses v1 = new frm_Ses();
            v1.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Inv_Soft v1 = new frm_Inv_Soft();
            v1.Show();
            this.Close();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void softwareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Inv_Soft v1 = new frm_Inv_Soft();
            v1.Show();
            this.Close();
        }
    }
}
