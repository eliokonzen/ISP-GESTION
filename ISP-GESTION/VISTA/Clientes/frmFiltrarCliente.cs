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
namespace VISTA.Clientes
{
    public partial class frmFiltrarCliente : Form
    {   CtrlClientes cCtrlClientes;
        public frmFiltrarCliente()
        {
            InitializeComponent();
        }
        public MODELO.Cliente oFiltardo;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            oFiltardo = new MODELO.Cliente();
            oFiltardo = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmFiltrarCliente_Load(object sender, EventArgs e)
        { cCtrlClientes = new CtrlClientes();
            dgvClientes.DataSource = cCtrlClientes.ListarClientes();
        }
    }
}
