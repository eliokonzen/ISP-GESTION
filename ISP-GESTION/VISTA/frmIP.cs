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
using tik4net;
using tik4net.Objects;

namespace VISTA
{
    public partial class frmIP : Form
    {
        List<tik4net.Objects.Ip.IpAddress> nueva;
        List<tik4net.Objects.Ip.IpAddress> vieja;
        public frmIP()
        {  
            InitializeComponent();
            Prueba cPrueba = new CONTROLADORA.Prueba();
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
            vieja = cPrueba.listIPAddressess();
            nueva = cPrueba.listIPAddressess();
            dtgActions.DataSource = nueva;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Prueba prueba = new CONTROLADORA.Prueba();
            prueba.updateIPAddressess(vieja, nueva);
            Actualizar_DtgActions();
        }
    }
}
