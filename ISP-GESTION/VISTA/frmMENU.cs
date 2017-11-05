using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.Conexiones;

namespace VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            frmIP frm = new frmIP();
            frm.Show();
        }

        private void gestionarConexionesToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            frmGestionarConexiones frm = new frmGestionarConexiones();
            frm.ShowDialog();
        }
    }
}
