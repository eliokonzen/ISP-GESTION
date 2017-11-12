using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODELO
{
    public class Conexion
    {
       
            
            public string Id { get; private set; }

            public string Name { get; set; }

           
            public string Password { get; set; }
          
            public string Profile { get; set; }

          
            public string Service { get; set; }

          
            public string LocalAddress { get; set; }

           public string RemoteAddress { get; set; }
    }
}
