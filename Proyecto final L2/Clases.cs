
public class Clases
{
    public string CodigoClase { get; set; }
    public int Cupos { get; set; }
    public string Descripcion { get; set; }
    public string Horario { get; set; }


    public Clases(string codigoClase, int cupos, string descripcion, string horario )
    {
        CodigoClase = codigoClase;
        Cupos = cupos;
        Descripcion = descripcion;
        Horario = horario;

    }


}