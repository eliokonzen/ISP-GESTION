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

        public void AddPlan(Plan oPlan)
        {
            var con = SingletonContext.GetContext();
            con.Planes.Add(oPlan);
            con.SaveChanges();
        }

        public List<Plan> DBPlanes()
        {
            var context = SingletonContext.GetContext();
            var attr = context.Planes.ToList();
            return attr.ToList();

        }
    }
}
