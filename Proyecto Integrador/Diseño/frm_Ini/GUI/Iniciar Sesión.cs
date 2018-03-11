using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Ini.GUI
{
    public partial class frm_Ses : Form
    {


        frm_Ini v1 = new frm_Ini();
        public frm_Ses()
        {
            InitializeComponent();
        }

        private void btn_Ac_Click(object sender, EventArgs e)
        {
            string Us = "Ray";
            string Con = "Rom01";

            if(txt_Us.Text== Us)
            {
                if (txt_Con.Text == Con)
                {
                    MessageBox.Show("Accediendo...");
                    v1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta, intente de nuevo.");
                    txt_Us.ResetText();
                    txt_Con.ResetText();
                }
            }else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta, intente de nuevo.");
                txt_Us.ResetText();
                txt_Con.ResetText();
            }
        }

        private void btn_Cer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
