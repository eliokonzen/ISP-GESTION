using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
  public class CtrlClientes
    {
        public void AgregarCliente (MODELO.Cliente oCliente)
        {
            var context = SingletonContext.GetContext();
            context.Clientes.Add(oCliente);
            context.SaveChanges();
        }
        public List<Cliente> ListarClientes ()
        {
            var context = SingletonContext.GetContext();
            return context.Clientes.ToList();
        }

    }
}
