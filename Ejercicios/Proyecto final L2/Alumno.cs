using System;
public class Alumno: Persona
{
    public string NumRegistro { get; set; }  

    public Alumno(string numRegistro, string nombres, string apellidos, int edad)         
    {
        NumRegistro = numRegistro;
        Nombres = nombres;
        Apellidos = apellidos;
        Edad = edad;
        
     
    }
    
    public void EnviarNotificacion()
    {
        Console.WriteLine("Correo enviado a: " + Nombres);
    }

    public void EnviarNotificacion(int telefono)
    {
        Console.WriteLine("Se ha enviado la notifacion de registro al telefono: " + Telefono);
    }

    
}