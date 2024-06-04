using EduRecuperacionC.Servicios;
using EduRecuperacionC.Util;
using EduRecuperacionC.Dtos;

namespace EduRecuperacionC
{
    class Program
    {
        public static string rutaCarpetaLog = "C:\\Users\\ruben\\Desktop\\Programacion\\EduRecuperacionC\\Logs\\";

        public static string rutaAlumnos = "alumnos.txt";

        public static string rutaFicheroAlumnos = String.Concat(rutaCarpetaLog, rutaAlumnos);

        public static string rutaFicheroLog = String.Concat(rutaCarpetaLog, Utilidades.crearNombreLog());

        public static List<AlumnoDto> listaAlumnos = new List<AlumnoDto>();
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            AlumnoInterfaz ai=new AlumnoImplementacion();

            int opcion;
            bool cerrarMenu = true;

            try
            {
                fi.cargaInicial(listaAlumnos);
            }catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex);
            }

            try
            {
                fi.escribirFicheroLog("HAS ENTRADO");
            }catch(Exception ex)
            {
                Console.WriteLine("ERROR " + ex);
            }                       

            do
            {
                try
                {
                    opcion = mi.menuYSeleccion();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("SE CIERRA EL MENU");
                            fi.escribirFicheroLog("SE CIERRA EL MENU");

                            cerrarMenu = false;                                                        
                            
                            break;
                        case 1:
                            Console.WriteLine("OPCION 1");
                            fi.escribirFicheroLog("ALTA ALUMNO");

                            ai.altaAlumno(listaAlumnos);
                            
                            /**Console.WriteLine("¿DESEA DAR DE ALTA A OTRO ALUMNO? s/n");
                            string respuesta1=Convert.ToString(Console.ReadLine());

                            if (respuesta1.Equals("s"))
                            {
                                ai.altaAlumno(listaAlumnos);
                            }
                            else if (respuesta1.Equals("n"))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("LA OPCION SELECCIONADA NO EXISTE");
                            }**/

                            break;
                        case 2:
                            Console.WriteLine("OPCION 2");
                            fi.escribirFicheroLog("ELIMINAR ALUMNO");

                            ai.eliminarAlumno(listaAlumnos);                            

                            /**Console.WriteLine("¿DESEA ELIMINAR A OTRO ALUMNO? s/n");
                            string respuesta2 = Convert.ToString(Console.ReadLine());

                            if (respuesta2.Equals("s"))
                            {
                                ci.eliminarAlumno(listaAlumnos);
                            }
                            else if (respuesta2.Equals("n"))
                            {
                                mi.menuYSeleccion();
                            }
                            else
                            {
                                Console.WriteLine("LA OPCION SELECCIONADA NO EXISTE");
                            }**/

                            break;
                        case 3:
                            Console.WriteLine("OPCION 3");
                            fi.escribirFicheroLog("MODIFICAR ALUMNOS");

                            ai.modificarAlumno(listaAlumnos);

                            break;
                        case 4:
                            Console.WriteLine("OPCION 4");
                            fi.escribirFicheroLog("MOSTRAR ALUMNOS");

                            ai.mostrarListaAlumnos(listaAlumnos);                            

                            break;
                        case 5:
                            Console.WriteLine("OPCION 5");
                            fi.escribirFicheroLog("ESCRIBIR ALUMNOS EN FICHERO");

                            Console.WriteLine("LOS ALUMNOS SE HAN ESCRITO EN EL FICHERO CORRECTAMENTE");
                            fi.escribirAlumnosFichero(listaAlumnos);

                            break;
                        default:
                            Console.WriteLine("LA OPCION SELECCIONADA NO EXISTE");
                            fi.escribirFicheroLog("LA OPCION SELECCIONADA NO EXISTE");

                            break;
                    }                    
                }
                catch (Exception ex1)
                {
                    try
                    {
                        fi.escribirFicheroLog("ERROR " + ex1);
                    }
                    catch(Exception ex2)
                    {
                        Console.WriteLine("ERROR " + ex2);
                    }                 
                }

            } while (cerrarMenu);
        }
    }
}

