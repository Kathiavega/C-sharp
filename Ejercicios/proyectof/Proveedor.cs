public class Proveedor:Persona
{
    public string CodigoProveedor { get; set; }

    public Proveedor(int codigo, string nombre, string codigoProveedor)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoProveedor = CodigoProveedor;
    }
}