using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblUSUARIO.Visible = false;
            lblCONTRASENA.Visible = false;
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            /*
            if (txtUsuario.Text == "admin")
            {
                if (txtContraseña.Text == "admin")
                {
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                }
                else
                {
                    lblCONTRASENA.Visible = true;
                }
            }
            else
            {
                lblUSUARIO.Visible = true;
            }

    */

            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
