using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;

namespace VISTA.Conexiones
{
    public partial class frmGestionarConexiones : Form
    {
        private readonly CONTROLADORA.CtrlConexiones cConexiones = new CONTROLADORA.CtrlConexiones();
        public frmGestionarConexiones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionarConexiones_Load(object sender, EventArgs e)
        {
            dgvConexiones.DataSource = cConexiones.DBObtenerConexiones();
            base.OnLoad(e);
        }
    }
}
