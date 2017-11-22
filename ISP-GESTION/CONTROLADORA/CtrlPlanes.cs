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
            con.CtrlPlanes.Add(oPlan);
            con.SaveChanges();
        }

        public List<Plan> DBPlanes()
        {
            var context = SingletonContext.GetContext();
            var attr = context.CtrlPlanes.ToList();
            return attr.ToList();

        }
    }
}
