using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class Plans
    {
        
        public int Id { get;  set; }
        public string Name { get; set; }
        public string LocalAddress { get; set; }
        public string RemoteAddress { get; set; }
        public string DnsServer { get; set; }
        public string RateLimit { get; set; }
        public ICollection<Conexion> Conexiones { get; set; }


    }
}
