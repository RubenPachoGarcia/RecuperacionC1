using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    internal class AlumnoDto
    {
        long id;
        string nombre = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string dni = "aaaaa";
        string direccion = "aaaaa";
        string email = "aaaaa";
        int telefono = 0;
        DateTime fechaNacimiento;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public AlumnoDto()
        {
        }

        override
        public string ToString()
        {
            string objetoString = String.Concat("DNI:", this.dni, "-", "Nombre:", this.nombre, "-", "Nacimiento:", this.FechaNacimiento);
            return objetoString;
        }

        public string ToString2()
        {
            string objetoString = String.Concat(this.dni, ";", this.nombre, ";", this.fechaNacimiento);
            return objetoString;
        }
    }
}
