using System.Collections.Generic;
public class NotasDetalle
{
    public List<Alumno> ListadeAlumnos { get; set; }
    public List<Clases> ListadeClases { get; set; }
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }
    public int Nota3 { get; set; }
    public int Nota4 { get; set; }
    public int Examen { get; set; } 
    public NotasDetalle(int nota1, int nota2, int nota3, int nota4, int examen)
    {
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
        Nota4 = nota4;
        Examen = examen;        
        ListadeAlumnos = new List<Alumno>();
        ListadeClases = new List<Clases>();
    }
}



    
