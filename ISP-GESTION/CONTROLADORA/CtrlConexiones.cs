﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
namespace CONTROLADORA
{
    public class CtrlConexiones
    {

        /// <summary>
        /// Prueba de Sumary
        /// </summary>
        public IList<Conexion> DBObtenerConexiones()
        {
            var context = SingletonContext.GetContext();
            return context.Conexiones.ToList();
            
        }

        public void add (MODELO.Conexion conexion)
        {
            var con = SingletonContext.GetContext();
            con.Conexiones.Add(conexion);
            con.SaveChanges();


        }
    }
}
