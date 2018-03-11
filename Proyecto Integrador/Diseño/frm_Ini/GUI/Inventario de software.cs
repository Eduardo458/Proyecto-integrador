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

namespace frm_Ini.GUI
{
    public partial class frm_Inv_Soft : Form
    {
        public frm_Inv_Soft()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Ini v1 = new frm_Ini();
            v1.Show();
            this.Close();
        }
    }
}
