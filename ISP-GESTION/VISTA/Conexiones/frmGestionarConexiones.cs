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
          //  cargaradb();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void frmGestionarConexiones_Load(object sender, EventArgs e)
        {
            dgvConexiones.DataSource = cConexiones.ListarConexiones();
         //  base.OnLoad(e);
        }
        private void cargaradb()
        {
            MODELO.Conexion oConexion = new MODELO.Conexion();
            //oConexion.Id = 15;
            //oConexion.Name = "Elio";
            //oConexion.Password = "1234";
            //oConexion.Profile = "default";
            //oConexion.RemoteAddress = "192.168.1.1";
            //oConexion.LocalAddress = "asdf";
            //oConexion.Service = "asdf";

            CONTROLADORA.CtrlConexiones cConexiones = new CONTROLADORA.CtrlConexiones();
            //cConexiones.add(oConexion);
            dgvConexiones.DataSource = cConexiones.ListarConexiones();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarConexion frm = new frmAgregarConexion();
            frm.ShowDialog();
        }

        private void btnFlitrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvConexiones.CurrentRow.DataBoundItem)
            {

            }
            MessageBox.Show("Desea eliminar la Conexion?", "Alerta", MessageBoxButtons.YesNo);
            DialogResult resultado = new DialogResult();
            if (resultado == DialogResult.OK)
            {
                
            }
        }
    }
}
