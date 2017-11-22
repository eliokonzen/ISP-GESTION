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

        public void AgregarPlan(Plans oPlan)
        {
            var cons = SingletonContext.GetContext();
            cons.Planes.Add(oPlan);
            cons.SaveChanges();
        }

        public List<Plans> ListarPlanes()
        {
            var context = SingletonContext.GetContext();
            var attr = context.Planes.ToList();
            return attr.ToList();

        }
    }
}
