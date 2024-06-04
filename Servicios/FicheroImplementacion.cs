using EduRecuperacionC.Dtos;
using EduRecuperacionC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion: FicheroInterfaz
    {
        public void escribirFicheroLog(string mensaje)
        {
            StreamWriter escribir = null;
            
            try
            {
                escribir = new StreamWriter(Program.rutaFicheroLog, true);

                escribir.WriteLine(mensaje);
                escribir.Close();
            }catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex);
            }

            if (File.Exists != null)
            {
                escribir.Close();
            }            
        }
        public void escribirAlumnosFichero(List<AlumnoDto> listaAlumnos)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(Program.rutaFicheroAlumnos);

                foreach (AlumnoDto alumnos in listaAlumnos)
                {
                    escribir.WriteLine(alumnos.ToString2());
                }

                escribir.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex);
            }
        }
        public void cargaInicial(List<AlumnoDto> listaAlumnos)
        {
            try
            {
                string ficheroAlumnos = Program.rutaFicheroAlumnos;
                string contenidoFichero;

                using (StreamReader sr = new StreamReader(ficheroAlumnos))
                {
                    contenidoFichero = sr.ReadToEnd();
                }

                string[] ficheroArray = contenidoFichero.Split('\n');

                for (int i = 0; i < ficheroArray.Length; i++)
                {
                    AlumnoDto alumno = new AlumnoDto();
                    string[] alumnoArray = ficheroArray[i].Split(';');

                    alumno.Dni = alumnoArray[0];
                    alumno.Nombre = alumnoArray[1];

                    listaAlumnos.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex);
            }
        }
    }
}
