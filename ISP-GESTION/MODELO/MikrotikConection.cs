using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
using System.Configuration;
namespace MODELO
{
    public class MikrotikConection
    {
        public ITikConnection connection = ConnectionFactory.OpenConnection(TikConnectionType.Api, ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);
        public static MikrotikConection instancia;
        public static MikrotikConection ObtenerInstancia()
        {


            if (instancia == null)
            {

                instancia = new MikrotikConection();

            }
            return instancia;

        }


    }
}
