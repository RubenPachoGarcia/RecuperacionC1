using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class AlumnoImplementacion: AlumnoInterfaz
    {
        FicheroInterfaz fi = new FicheroImplementacion();
        public AlumnoDto altaAlumno(List<AlumnoDto> listaAlumnos)
        {
            AlumnoDto alumno = new AlumnoDto();
                       
            long idAlumno = idAutomatico(listaAlumnos);
            idAlumno = alumno.Id;
            Console.WriteLine("Introduzca su nombre: ");
            alumno.Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su primer apellido: ");
            alumno.Apellido1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su segundo apellido: ");
            alumno.Apellido2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su DNI: ");
            alumno.Dni = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su direccion: ");
            alumno.Direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su email: ");
            alumno.Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca su telefono: ");
            alumno.Telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca su fecha de nacimiento (dd/MM/yyyy): ");
            alumno.FechaNacimiento=Convert.ToDateTime(Console.ReadLine());

            listaAlumnos.Add(alumno);  
            
            return alumno;
        }

        private long idAutomatico(List<AlumnoDto> listaAlumnos)
        {
            long id;
            int tamanioLista=listaAlumnos.Count;

            if(tamanioLista==0)
            {
                id=1;
            }
            else
            {
                id = tamanioLista - 1;
            }

            return id;
        }
        public void eliminarAlumno(List<AlumnoDto> listaAlumnos)
        {
            AlumnoDto aux= new AlumnoDto(); 

            Console.WriteLine("INTRODUZCA EL DNI DEL ALUMNO A ELIMINAR: ");
            string dniAEliminar=Convert.ToString(Console.ReadLine());

            int contador = 0;

            foreach(AlumnoDto alumno in listaAlumnos)
            {
                if (dniAEliminar.Equals(alumno.Dni))
                {
                    contador = 1;
                    aux = alumno;
                    break;
                }
            }
            if(contador!=0)
            {
                Console.WriteLine("EL ALUMNO HA SIDO ELIMINADO CON EXITO");
                listaAlumnos.Remove(aux);
            }
            else
            {
                Console.WriteLine("EL DNI DEL ALUMNO A ELIMINAR NO ES CORRECTO O NO EXISTE");
            }
        }
        public void modificarAlumno(List<AlumnoDto> listaAlumnos)
        {
            Console.WriteLine("INDIQUE EL DNI DEL ALUMNO QUE DESEA MODIFICAR: ");
            string dniAlumnoAModificar = Convert.ToString(Console.ReadLine());
            
            foreach (AlumnoDto alumno in listaAlumnos)
            {
                if (dniAlumnoAModificar.Equals(alumno.Dni))
                {
                    bool control = true;

                    while (control)
                    {
                        int opcion = mostrarMenuModificacionAlumno();
                        control = modificarCampoAlumno(alumno, opcion);
                    }
                }
            }
        }
        private int mostrarMenuModificacionAlumno()
        {
            int opcionUsuario;
            
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. NOMBRE");
            Console.WriteLine("2. APELLIDO1");
            Console.WriteLine("3. APELLIDO2");
            Console.WriteLine("4. DIRECCION");
            Console.WriteLine("5. EMAIL");
            Console.WriteLine("6. TELEFONO");
            Console.WriteLine("7. FECHA DE NACIMIENTO");
            Console.WriteLine("-------------------");
            Console.WriteLine("SELECCIONE LA OPCION QUE DESEE:");
            
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            
            return opcionUsuario;
        }
        private bool modificarCampoAlumno(AlumnoDto alumnoAModificar, int opcionUsuario)
        {
            bool abrirMenu = true;
            switch (opcionUsuario)
            {
                case 0:
                    abrirMenu = false;
                    break;
                case 1:
                    Console.WriteLine("NUEVO NOMBRE: ");
                    alumnoAModificar.Nombre = Convert.ToString(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("NUEVO APELLIDO1: ");
                    alumnoAModificar.Apellido1 = Convert.ToString(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("NUEVO APELLIDO2: ");
                    alumnoAModificar.Apellido2 = Convert.ToString(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("NUEVA DIRECCION: ");
                    alumnoAModificar.Direccion = Convert.ToString(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("NUEVO EMAIL: ");
                    alumnoAModificar.Email = Convert.ToString(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("NUEVO TELEFONO: ");
                    alumnoAModificar.Telefono = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("NUEVA FECHA DE NACIMIENTO (dd/MM/yyyy): ");
                    alumnoAModificar.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("LA OPCION SELECCIONADA NO EXISTE");
                    break;
            }
            return abrirMenu;
        }
        public void mostrarListaAlumnos(List<AlumnoDto> listaAlumnos)
        {
            foreach(AlumnoDto alumnos in listaAlumnos)
            {
                Console.WriteLine(alumnos.ToString());
            }
        }
    }
}
