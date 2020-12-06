public class Acreedor:Persona
{
    public double Saldo { get; set; }

    public Acreedor(int codigo, string nombre, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
    }
}