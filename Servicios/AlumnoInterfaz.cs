using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface AlumnoInterfaz
    {
        public AlumnoDto altaAlumno(List<AlumnoDto> listaAlumnos);
        public void eliminarAlumno(List<AlumnoDto> listaAlumnos);
        public void modificarAlumno(List<AlumnoDto> listaAlumnos);
        public void mostrarListaAlumnos(List<AlumnoDto> listaAlumnos);
    }
}
