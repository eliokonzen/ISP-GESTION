using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
namespace CONTROLADORA
{
    public class CtrlConexiones
    {
      public IList<Conexion> DBObtenerConexiones()
        {
            var context = SingletonContext.GetContext();
            return context.Conexiones.ToList();
            
        }
    }
}
