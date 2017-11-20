using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
   public class CtrlPlanes
    {

        public void AddPlan()
        {
            MODELO.Plan oPlan = new Plan();
            oPlan.Name = "2 megas";
            oPlan.LocalAddress = "192.168.1.1";
            oPlan.RemoteAddress = "192.168.1.88";
            oPlan.DnsServer = "8.8.8.8";
            oPlan.RateLimit = "12/24";
            

            var con = SingletonContext.GetContext();
            con.Planes.Add(oPlan);
            con.SaveChanges();



        }
    }
}
