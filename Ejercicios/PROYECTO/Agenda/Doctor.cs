using System;

public class Doctor: Persona
{   
    public int CodigoDoctor { get; set; }
    public string Horario { get; set; }

    public Doctor(int codigo, int codigodoctor, string nombre, string apellido, string telefono, string horario)
    {
        Codigo = codigo;
        CodigoDoctor = codigodoctor;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Horario = horario;
    }
}