using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion:MenuInterfaz
    {
        public int menuYSeleccion()
        {          
            int opcionUsuario;

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("-------------------");
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. ALTA ALUMNO");
            Console.WriteLine("2. ELIMINAR ALUMNO");
            Console.WriteLine("3. MODIFICAR ALUMNO");
            Console.WriteLine("4. MOSTRAR LISTADO DE ALUMNOS");
            Console.WriteLine("5. ESCRIBIR ALUMNOS EN FICHERO");
            Console.WriteLine("-------------------");
            Console.WriteLine("SELECCIONE LA OPCION QUE DESEE: ");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());           
            
            return opcionUsuario;
        }
    }
}
