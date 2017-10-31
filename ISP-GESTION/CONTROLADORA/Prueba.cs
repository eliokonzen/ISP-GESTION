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
        
        //Ejemplo de como eliminar IpAddress con el ORM Tik4net
        public void delateIPAddressess(IpAddress oIpAddress)
        {

            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            cConexion.connection.Delete<IpAddress>(oIpAddress);
        }

        //Elio malo qleado filho da puta
        //Vai come rola 


    }
}
