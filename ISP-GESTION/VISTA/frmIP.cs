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

namespace VISTA
{
    public partial class frmIP : Form
    {
        public frmIP()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            
            Actualizar_DtgActions();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Prueba cPrueba = new CONTROLADORA.Prueba();
            var oIpAddress = (tik4net.Objects.Ip.IpAddress)dtgActions.CurrentRow.DataBoundItem;
            cPrueba.delateIPAddressess(oIpAddress);

            Actualizar_DtgActions();

        }

        private void frmIP_Load(object sender, EventArgs e)
        {

        }

        //Actualizacion de la grilla 
        private void Actualizar_DtgActions()
        {
            Prueba cPrueba = new CONTROLADORA.Prueba();
            dtgActions.DataSource = cPrueba.listIPAddressess();
        }
    }
}
