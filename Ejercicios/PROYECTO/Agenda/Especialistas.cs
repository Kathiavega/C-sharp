using System;

public class Especialistas: Persona
{   
    public int CodigoEspecialista { get; set; }
    public string Horario { get; set; }
    public string Especialidad { get; set; }

    public Especialistas(int codigo, int codigoEspecialista, string nombre, string apellido, string telefono, string horario, string especialidad)
    {
        Codigo = codigo;
        CodigoEspecialista = codigoEspecialista;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Horario = horario;
        Especialidad = especialidad;
    }
    
}