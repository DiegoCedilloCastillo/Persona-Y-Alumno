using System;
using System.Collections.Generic;
using System.Text;

namespace _Persona_Y_Alumno
{
    class Alumno : Persona
    {
        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Alumno()
        {
            matricula = "";
            carrera = "";
        }

        public Alumno(string nombre, string fechaNacimiento,
            string carrera, string matricula) : base(fechaNacimiento, nombre)
        {
            this.carrera = carrera;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return "Informacion del alumno... \n" + "Nombre: " + nombre
                + "\nFecha de nacimiento: " + fechaNacimiento
                + "\nCarrera: " + carrera + "\nMatricula: " + matricula;
        }
    }
}
