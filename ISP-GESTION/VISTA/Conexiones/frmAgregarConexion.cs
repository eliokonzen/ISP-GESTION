using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADORA;
namespace VISTA.Conexiones
{
    public partial class frmAgregarConexion : Form
    {   
        CtrlClientes cCtrlClientes = new CtrlClientes();
        CtrlPlanes cCtrlPlanes = new CtrlPlanes();

        Cliente oCliente;

        public frmAgregarConexion()
        {
            InitializeComponent();
            CargaInicial();
        }
        

        //Devuelve el objeto Cliente que se filtra a travez del formulario Clientes.frmFiltarClientes
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            oCliente = new Cliente();

            Clientes.frmFiltrarCliente frmFiltrar = new Clientes.frmFiltrarCliente();

            if (frmFiltrar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("s");
                oCliente = frmFiltrar.oFiltardo;
                txtClienteNombre.Text = oCliente.Nombre + " " + oCliente.Apellido;
                txtOrganizacion.Text = oCliente.Organizacion;
               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        //Carga inicial de los Planes en el combobox
        private void CargaInicial()
        {
            cmbPlan.DataSource = cCtrlPlanes.ListarPlanes();

        }
    }
}
