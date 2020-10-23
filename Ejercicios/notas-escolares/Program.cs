using System;

namespace notas_escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Codigo = 1;
            alumno1.Nombre = "Juan";
            alumno1.ingresarNota();

            Alumno a = new Alumno();
            a.Codigo = 2;
            a.Nombre = "Pedro";
            a.ingresarNota();

            Console.WriteLine("Alumno: " + alumno1.Nombre);
            Console.WriteLine("Alumno: " + a.Nombre);
        }
    }
}
