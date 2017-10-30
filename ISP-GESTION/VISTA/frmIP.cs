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
    public partial class frmIP : Form
    {
        public frmIP()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            //ss
            CONTROLADORA.Prueba cPrueba = new CONTROLADORA.Prueba();
            dtgActions.DataSource = cPrueba.listIPAddressess();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             CONTROLADORA.Prueba cPrueba = new CONTROLADORA.Prueba();
            var ss = (tik4net.Objects.Ip.IpAddress)dtgActions.CurrentRow.DataBoundItem;
            cPrueba.delateIPAddressess(ss);
            dtgActions.DataSource = cPrueba.listIPAddressess();

        }
    }
}
