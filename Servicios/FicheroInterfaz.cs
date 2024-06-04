using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface FicheroInterfaz
    {
        public void escribirFicheroLog(string mensaje);
        public void escribirAlumnosFichero(List<AlumnoDto> listaAlumnos);
        public void cargaInicial(List<AlumnoDto> listaAlumnos);
    }
}
