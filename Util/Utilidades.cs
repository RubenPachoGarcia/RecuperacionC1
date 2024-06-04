using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    internal static class Utilidades
    {
        public static string crearNombreLog()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("ddMMyy");
            
            string nombreLog = String.Concat("log-", fechaFormateada, ".txt");           

            return nombreLog;
        }
    }
}
