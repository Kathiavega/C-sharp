using System;

public class Pacientes: Persona
{
    public string Edad { get; set; }
    public string Correo { get; set; }
    public string Identidad { get; set; }

    public Pacientes(int codigo, string nombre, string apellido, string telefono, string edad, string correo, string identidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Edad = edad;
        Correo = correo;
        Identidad = identidad;
    }
}