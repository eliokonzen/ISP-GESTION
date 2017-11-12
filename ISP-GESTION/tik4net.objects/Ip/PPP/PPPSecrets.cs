using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tik4net.Objects.Ip.PPP
{
    [TikEntity("ppp/secret")]
   public class PPPSecrets
    {
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        [TikProperty("name", IsMandatory = true)]
        public string Name { get; set; }

        [TikProperty("password")]
        public string Password { get; set; }
        [TikProperty("profile")]
        public string Profile { get; set; }

        [TikProperty("service")]
        public string Service { get; set; }

        [TikProperty("local-address")]
        public string LocalAddress { get; set; }

        [TikProperty("remote-address")]
        public string RemoteAddress { get; set; }
    }
}
