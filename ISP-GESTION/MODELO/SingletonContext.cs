using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using System.Data.Entity;

namespace MODELO
{
    public static class SingletonContext
    {
        
        private static Container _container = null;

        public static void CreateInstance()
        {
            Bootstrap();
        }

        private static void Bootstrap()
        {
            if (_container != null) return;

            _container = new Container();
            _container.Register<DbContext, Context>();
        }

        public static Context GetContext()
        {
            var context = _container.GetInstance<Context>();
            return context;
        }
    }

}

