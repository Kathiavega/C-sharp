using System.Collections.Generic;
public class Notas
{
    public List<NotasDetalle> ListadodeNotas { get; set; }
    public Matricula Alumno { get; set; }
    public Matricula Materia { get; set; }
    
    public int NotaFinal { get; set; }   

    

    public Notas(Matricula alumno,Matricula materia)
    {
        Alumno = alumno;
        Materia = materia;
        ListadodeNotas = new List<NotasDetalle>();
    }

      public void AgregarNotas(int nota1, int nota2, int nota3, int nota4, int examen)
       {

           NotasDetalle nota = new NotasDetalle(nota1,nota2,nota3,nota4,examen);
           ListadodeNotas.Add(nota);

          NotaFinal = nota1+nota2+nota3+nota4+examen;
       }

}