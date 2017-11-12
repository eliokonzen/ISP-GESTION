using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
using tik4net.Objects.Ip.PPP;
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

        public void updateIPAddressess (List<IpAddress> oldList, List<IpAddress> newList)
        {
            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            cConexion.connection.SaveListDifferences(newList, oldList);
     
        }
        public List<PPPSecrets> ObtenerConexiones()
        {
            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            var lista = cConexion.connection.LoadList<PPPSecrets>();
            return lista.ToList();

        }
        public void UpdateConexiones(List<PPPSecrets> oldList, List<PPPSecrets> newList)
        {
            cConexion = MikrotikConection.OBTENER_INSTANCIA();
            cConexion.connection.SaveListDifferences(newList, oldList);
        }
        //Elio malo qleado filho da puta
        //Vai come rola 


    }
}
