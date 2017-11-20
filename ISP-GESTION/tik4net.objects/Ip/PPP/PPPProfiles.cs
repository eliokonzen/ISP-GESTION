using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tik4net.Objects.Ip.PPP
{


    [TikEntity("ppp/profile")]
    public  class PPPProfiles
    {
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }


       
        [TikProperty("name")]
        public string Name { get; set; }

     
        [TikProperty("local-address")]
        public string LocalAddress { get; set; }

       
        [TikProperty("remote-address")]
        public string RemoteAddress { get; set; }

        [TikProperty("dns-server")]
        public string DnsServer { get; set; }

        
        [TikProperty("rate-limit")]
        public string RateLimit { get; set; }

    }
}
