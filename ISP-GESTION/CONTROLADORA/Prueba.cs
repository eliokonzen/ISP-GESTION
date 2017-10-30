using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
namespace CONTROLADORA
{
    public class Prueba
    {
        CONTROLADORA.MikrotikConection cConexion;

        public List<IpAddress> listIPAddressess()
        {

            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            var lista = cConexion.connection.LoadList<IpAddress>();
            return lista.ToList();

        }
        public void delateIPAddressess(IpAddress ss)
        {

            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            
        }


    }
}
