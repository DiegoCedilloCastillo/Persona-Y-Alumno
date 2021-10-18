using System;

namespace _Persona_Y_Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1;
            p1 = new Persona();
            Console.Write("Nombre de la persona: ");
            p1.Nombre = Console.ReadLine();
            Console.Write("Fecha de nacimiento de la persona: ");
            p1.FechaNacimiento = Console.ReadLine();
            Console.WriteLine(p1.ToString());

            Alumno a1;
            a1 = new Alumno();
            Console.Write("Nombre del alumno: ");
            a1.Nombre = Console.ReadLine();
            Console.Write("Fecha de nacimiento del alumno: ");
            a1.FechaNacimiento = Console.ReadLine();
            Console.Write("Carrera del alumno: ");
            a1.Carrera = Console.ReadLine();
            Console.Write("Matricula del alumno: ");
            a1.Matricula = Console.ReadLine();
            Console.WriteLine(a1.ToString());

            Console.ReadKey();

        }
    }
}
