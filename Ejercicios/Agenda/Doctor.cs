using System;

public class Doctor: Persona
{   
    public string CodigoDoctor { get; set; }
    public string Horario { get; set; }

    public Doctor(int codigo, string codigodoctor, string nombre, string apellido, string telefono, string horario)
    {
        Codigo = codigo;
        CodigoDoctor = codigodoctor;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Horario = horario;
    }
}