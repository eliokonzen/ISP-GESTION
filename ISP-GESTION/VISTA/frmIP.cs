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
using tik4net.Objects.Ip.PPP;

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
            MODELO.Cliente oCliente = new MODELO.Cliente();
            CtrlClientes cC = new CtrlClientes();
            oCliente.Nombre = "Juan";
            oCliente.Apellido = "Jalignier";
            oCliente.Organizacion = "MR Muebles";
            cC.AgregarCliente(oCliente);

            MODELO.Plans oPlan = new MODELO.Plans();
            CtrlPlanes cP = new CtrlPlanes();
            oPlan.Name = "2 Megas";
            oPlan.LocalAddress = "192";
            oPlan.RemoteAddress = "321";
            oPlan.DnsServer = "8";
            oPlan.RateLimit = "24";
            cP.AgregarPlan(oPlan);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           

        }

        private void frmIP_Load(object sender, EventArgs e)
        {

        }

     
     

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
