using System.Collections.Generic;
using System;
public class Matricula
{
    public Alumno Alumno { get; set; }
    public Clases Materia { get; set; }
    public int CodigoMatricula { get; set; }
    public DateTime Fecha { get; set; }
   

    public Matricula(int codigoMatricula, DateTime fecha, Alumno alumno, Clases materia)
    {
        Fecha = fecha;
        Alumno = alumno;
        Materia = materia;
        CodigoMatricula = codigoMatricula;
       
      
    }
    

     

}