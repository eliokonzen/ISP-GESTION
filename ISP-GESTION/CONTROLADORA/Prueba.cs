using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
using tik4net.Objects.Ip.PPP;
using MODELO;
namespace CONTROLADORA
{
    public class Prueba
    {
        MODELO.MikrotikConection cConexion;

        public List<IpAddress> listIPAddressess()
        {

            cConexion = MikrotikConection.ObtenerInstancia();
            var lista = cConexion.connection.LoadList<IpAddress>();
            return lista.ToList();

        }
        
        //Ejemplo de como eliminar IpAddress con el ORM Tik4net
        public void delateIPAddressess(IpAddress oIpAddress)
        {

            cConexion = MikrotikConection.ObtenerInstancia();
            cConexion.connection.Delete<IpAddress>(oIpAddress);
        }

        public void updateIPAddressess (List<IpAddress> oldList, List<IpAddress> newList)
        {
            cConexion = MikrotikConection.ObtenerInstancia();
            cConexion.connection.SaveListDifferences(newList, oldList);
     
        }
        public List<PPPSecrets> ObtenerConexiones()
        {
            cConexion = MikrotikConection.ObtenerInstancia();
            var lista = cConexion.connection.LoadList<PPPSecrets>();
            return lista.ToList();

        }
        public void UpdateConexiones(List<PPPSecrets> oldList, List<PPPSecrets> newList)
        {
            cConexion = MikrotikConection.ObtenerInstancia();
            cConexion.connection.SaveListDifferences(newList, oldList);
        }
        //Elio malo qleado filho da puta
        //Vai come rola 

        public List<PPPProfiles> ObtenerProfiles()
        {
            cConexion = MikrotikConection.ObtenerInstancia();
            var lista = cConexion.connection.LoadList<PPPProfiles>();
            return lista.ToList();

        }
    }
}
