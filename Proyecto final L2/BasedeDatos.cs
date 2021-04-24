using System.Collections.Generic;
using System;

public class BasedeDatos
{
    public List<Alumno> ListadeAlumnos { get; set; }
    public List<Clases> ListadeClases { get; set; }
    public List<Matricula> ListaMatricula { get; set; }
    public List<Notas> ListadeNotas { get; set; }

        public BasedeDatos()
        {
            ListadeAlumnos = new List<Alumno>();
            cargarAlumnos();

            ListadeClases = new List<Clases>();
            clasesDisponibles();

            ListaMatricula = new List<Matricula>();
            ListadeNotas = new List<Notas>();
            
        }

        public void cargarAlumnos()
        {
            Alumno a1 = new Alumno("T0001", "Paola Anaytee", "Torres Salinas", 16);
            ListadeAlumnos.Add(a1);
            
            Alumno a2 = new Alumno("T0002","Belkis Tatiana", "Rivera Dominguez", 14);
            ListadeAlumnos.Add(a2);

        
        }

        public void clasesDisponibles()
        {
            Clases claseA = new Clases("FFE-030", 3, "Español", "De 7:00 A 8:00 am");
            ListadeClases.Add(claseA);

            Clases claseB = new Clases("FFI-140", 4, "Inglés", "De 8:00 A 9:00 am");
            ListadeClases.Add(claseB);

            Clases claseC = new Clases("FFM-130", 9, "Matemática", "De 9:00 A 10:00 am");
            ListadeClases.Add(claseC);

            Clases claseD = new Clases("FFC-160", 8, "Ciencias naturales", "De 10:00 A 11:00 pm");
            ListadeClases.Add(claseD);
        }

    public void ListarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Datos Generales");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  Codigo Alumno"  + "     Edad"       + "       Nombre del Alumno(a)");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var alumno in ListadeAlumnos)
            {
                Console.WriteLine("     " + alumno.NumRegistro + "         | " + alumno.Edad  + " |        " + alumno.Nombres +" "+  alumno.Apellidos);

            }

            Console.ReadLine();
        }

    public void ListarClases()
        {
            Console.Clear();
            Console.WriteLine("Clases Disponibles");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Codigo de clase" + "     Cupos Disponibles "+ "     Horarios "  + "         Descripcion de la clase " );
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            foreach (var clase in ListadeClases)
            {
                Console.WriteLine("   " + clase.CodigoClase + "       |        " + clase.Cupos + "     |      " + clase.Horario + "          |       " + clase.Descripcion   );
            }
            Console.ReadLine();
        }

    public void IngresarAlumno()
    {
        Console.Clear();
        Console.WriteLine("Registro de Alumnos");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Ingrese Nombre(s): ");
        string nombre = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Ingrese Apellido(s): ");
        string apellidos = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Ingrese edad: ");
        string linea = Console.ReadLine();
        int edad = Int32.Parse(linea);


        Random rnd = new Random();
        int nuevoRegistro = 0;

        nuevoRegistro = rnd.Next(4,100);

        Alumno nuevoAlumno = new Alumno("T0001" + nuevoRegistro.ToString(), nombre, apellidos, edad);
        ListadeAlumnos.Add(nuevoAlumno);

        Console.WriteLine("Se registro corretamente");
        Console.ReadLine();

    }

    public void ModificarAlumno()
    {
        Console.Clear();
        Console.WriteLine("Eliminar Registro de Alumnos");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");
        Console.Write("Ingrese codigo de Alumno que desea eliminar del registro: ");
        string codigoAlumno = Console.ReadLine();
        Alumno alumno = ListadeAlumnos.Find(a => a.NumRegistro == codigoAlumno.ToUpper());
        if (alumno == null)
        {
            Console.Write("Alumno(a) no encontrado(a)");
            Console.ReadLine();
            return;
        }else
        {
            foreach (var estudiante in ListadeAlumnos)
            {
                if (estudiante.NumRegistro == codigoAlumno.ToUpper())
                {
                    Console.WriteLine("Registro de alumno(a) a eliminar: " + alumno.Nombres + " " + alumno.Apellidos + " " + alumno.Edad + " de edad");
                    Console.WriteLine("");

                   
                    Console.Write("Confirmar la anulacion del registro del alumno(a) s/n: ");
                    string resp = Console.ReadLine();

                    if (resp.ToLower() == "s")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Se ha eliminado el registro");

                        ListadeAlumnos.Remove(estudiante);
                        Console.ReadLine();
                        return;
                    }
                }
            }          
        }
 
    }

        private void RegistrodeClase(string codigoClase, string tipoMovimiento)
        {
            foreach (var clase in ListadeClases)
            {
            
                if (clase.CodigoClase == codigoClase || clase.CodigoClase.ToLower() == codigoClase)
                {
                    if (tipoMovimiento == "-" && clase.Cupos != 0)
                    {
                        clase.Cupos = clase.Cupos - 1;                                    
                        
                     }  
                }  
            }
            Console.ReadLine();
        }

        private void RetirodeClase(string codigoClase, string tipoMovimiento)
        {
            foreach (var clase in ListadeClases)
            {
            
                if (clase.CodigoClase == codigoClase || clase.CodigoClase.ToLower() == codigoClase)
                {
                    if (tipoMovimiento == "+" && clase.Cupos != 2)
                    {
                        clase.Cupos = clase.Cupos + 1;                                    
                        
                    } 
                }  
            }
            Console.ReadLine();
        }
    public void MatriculaAlumno() 
    {
        while (true)
        {
            string codigoClase = "";
            string codigoAlumno = "";

            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Sistema de Matricula");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.Write("Ingrese el codigo de la clase que desea matricular: ");
            codigoClase = Console.ReadLine();
            Clases cs = ListadeClases.Find(c => c.CodigoClase == codigoClase.ToUpper());
            if (cs == null)
            {
                Console.Write("Clase no encontrada");
                Console.ReadLine();
                return;
            }else
            {
                Console.WriteLine("La clase es: " + cs.Descripcion);
                Console.WriteLine("");
            }        
            
            Console.Write("Ingrese codigo de Alumno a matricular: ");
            codigoAlumno = Console.ReadLine();
            Alumno alumno = ListadeAlumnos.Find(a => a.NumRegistro == codigoAlumno.ToUpper());
            if (alumno == null)
            {
                Console.Write("Alumno no encontrado");
                Console.ReadLine();
                return;
            }else
            {
                foreach (var matriculado in ListaMatricula)
                {
                    if (matriculado.Materia.CodigoClase == codigoClase.ToUpper() && matriculado.Alumno.NumRegistro == codigoAlumno.ToUpper())
                    {
                        Console.WriteLine("Alumno " + matriculado.Alumno.Nombres + " " + matriculado.Alumno.Apellidos + " ya esta matriculado en la clase");
                        Console.ReadLine();
                        return;
                    }
                } 
                
                if (cs.Cupos != 0)
                {
                    Random rnd = new Random();
                    int nuevoCodMatricula = 0;

                    nuevoCodMatricula = rnd.Next(4,100);
                    Matricula nuevaMatricula = new Matricula(nuevoCodMatricula, DateTime.Now, alumno, cs);
                    ListaMatricula.Add(nuevaMatricula);     

                    Console.WriteLine("");
                    Console.WriteLine("Alumno(a) " + alumno.Nombres + " " + alumno.Apellidos + " ha sido matriculado en la clase ");
                    Console.WriteLine(""); 
                    RegistrodeClase(codigoClase, "-");  
                    
                    Console.WriteLine("Cupos disponibles en esta asignatura " + nuevaMatricula.Materia.Cupos);  
                    Console.WriteLine("");        
                            
                    Console.Write("Desea matricular otro alumno(a)/materia s/n: ");
                    string continuar = Console.ReadLine();

                    if (continuar.ToLower() == "n")
                    {
                        break; 
                    }     
                }else
                {   Console.WriteLine(""); 
                    Console.WriteLine("No hay cupos disponibles en esta materia");
                    Console.ReadLine();
                    return;
                }
               
            }

        }
       
    }

    public void RetirarAlumno() 
    {
        string codigoClase = "";
        string codigoAlumno = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Sistema de Anulacion de Matricula");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("");
        Console.Write("Ingrese el codigo de la clase que desea retirar: ");
        codigoClase = Console.ReadLine();
        Clases cs = ListadeClases.Find(c => c.CodigoClase == codigoClase.ToUpper());
        if (cs == null)
        {
            Console.Write("Clase no encontrada");
            Console.ReadLine();
            return;
        }else
        {
            Console.WriteLine("La clase a retirar es: " + cs.Descripcion);
            Console.WriteLine("");
        }
        
        Console.Write("Ingrese codigo de Alumno que retira la clase: ");
        codigoAlumno = Console.ReadLine();
        Alumno alumno = ListadeAlumnos.Find(a => a.NumRegistro == codigoAlumno.ToUpper());
         if (alumno == null)
         {
             Console.Write("Alumno no encontrado");
             Console.ReadLine();
             return;
         }else
         {
            if (cs.Cupos !=5)
            {
                 foreach (var persona in ListaMatricula)
                {
                    if (persona.Materia.CodigoClase == codigoClase.ToUpper() && persona.Alumno.NumRegistro == codigoAlumno.ToUpper())
                    {
                        
                        Console.WriteLine("Alumno(a) " + alumno.Nombres + " " + alumno.Apellidos);
                        Console.WriteLine("");
                        Console.Write("Confirmar el retiro del alumno(a) de la clase " + persona.Materia.Descripcion + " s/n: ");
                        string resp = Console.ReadLine();

                        if (resp.ToLower() == "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Alumno(a) ha sido retirado de la clase");

                            ListaMatricula.Remove(persona);
                            RetirodeClase(codigoClase, "+"); 
                            return;
                        }
                                    
                    }
                } 
            }else
            {
                Console.WriteLine("Ha alzanzado los cupos maximos permitidos para esta materia");
            }
            
                
            Console.ReadLine();
         }                  
    }

    public void ListarMatriculas()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Lista de Matriculados");
        Console.WriteLine("---------------------");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Cod. Matricula " + " Cod. Alumno " + "             Nombre Completo " +  "                 Cod. Clase Matriculada " + "      Clase Matriculada " + "      Fecha y Hora de Matricula");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
        foreach (var matricula in ListaMatricula)
        {
            Console.WriteLine(matricula.CodigoMatricula + "              | " + matricula.Alumno.NumRegistro + "       | " + matricula.Alumno.Nombres + " " + matricula.Alumno.Apellidos + "                   | " +  matricula.Materia.CodigoClase + "                       | " + matricula.Materia.Descripcion  + "              | " + matricula.Fecha);
            Console.WriteLine("");
            
            
        }
        Console.ReadLine();
    }
   
      public void ListarNotas()
      {
          Console.Clear();
          Console.WriteLine("Lista de Calificaciones");
          Console.WriteLine("-----------------------");
          Console.WriteLine("");
          Console.WriteLine("Codigo Alumno(a)" + "        Nombre      " + "               Apellido    " + "            Codigo de clase  " + "     Materia   " + "       Nota Final");
          Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
          foreach (var nota in ListadeNotas)
             {
                 Console.WriteLine(nota.Alumno.Alumno.NumRegistro + "            | " + nota.Alumno.Alumno.Nombres + "            | " + nota.Alumno.Alumno.Apellidos + "           |  " + nota.Materia.Materia.CodigoClase + "           | " +nota.Materia.Materia.Descripcion + "    |      " + nota.NotaFinal +"%"); //+ " | " + nota.Nota1 + " | " + nota.Nota2 + " | " + nota.Nota3 + " | " + nota.Nota4 + " | " + nota.Examen);
                 Console.WriteLine("");
                 Console.WriteLine("Nota 1" +  "  Nota 2 " + " Nota3" + "    Nota 4 " + "  Examen");
                 foreach (var item in nota.ListadodeNotas)
                 {
                     Console.WriteLine(item.Nota1 + "    | "+ item.Nota2 + "     | " + item.Nota3 + "     | " + item.Nota4 + "   | " + item.Examen);
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                 }
             }
                Console.ReadLine();

      }

    public void IngresarNotas()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ingreso de calificaciones");
        Console.WriteLine("-------------------------");
        Console.WriteLine("");

            Console.WriteLine("Lista de matriculados");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

        foreach (var item in ListaMatricula)
        {
            
            Console.WriteLine("Alumno(a):                       " + item.Alumno.Nombres + " " + item.Alumno.Apellidos );
            Console.WriteLine("Matriculado(a) en la clase de:  "  + item.Materia.Descripcion);
            Console.WriteLine("Codigo de Alumo(a):              " + item.Alumno.NumRegistro);
            Console.WriteLine("Codigo de clase:                 " + item.Materia.CodigoClase);
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("");
        }

        Console.Write("Ingrese el Codigo del alumno que califica: ");
        string codAlumno = Console.ReadLine();
        Console.WriteLine("");
        Matricula alumno = ListaMatricula.Find(a => a.Alumno.NumRegistro == codAlumno.ToUpper());

            if (alumno == null)
            {
                Console.Write("Codigo de alumno incorrecto");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Usted esta calificando a " + alumno.Alumno.Nombres + " " + alumno.Alumno.Apellidos);
                Console.WriteLine("");
            }
        Console.Write("Ingrese el codigo de la clase que desea calificar: ");
        string codigoClase = Console.ReadLine();
        Console.WriteLine("");
        Matricula codClase = ListaMatricula.Find(c => c.Materia.CodigoClase == codigoClase.ToUpper());
            if (codClase == null)
            {
            Console.Write("Codigo de clase incorrecto");
            Console.ReadLine();
            return;
            }    
            else
            {       
                foreach (var item in ListadeNotas)
                {
                    if (item.Materia.Materia.CodigoClase == codigoClase.ToUpper() && item.Alumno.Alumno.NumRegistro== codAlumno.ToUpper())
                    {
                        Console.WriteLine("Alumno(a) ya fue calificado");
                        Console.ReadLine();
                        return;
                    }
                }

                        int nota1 = 0;
                        int nota2 = 0;
                        int nota3 = 0;
                        int nota4 = 0;
                        int examen = 0;                        

                        Console.Write("Ingrese calificacion 1: ");
                        string linea = Console.ReadLine();
                        nota1 = Int32.Parse(linea);

                        Console.Write("Ingrese calificacion 2: ");
                        string linea2 = Console.ReadLine();
                        nota2 = Int32.Parse(linea2);
                        
                        Console.Write("Ingrese calificacion 3: ");
                        string linea3 = Console.ReadLine();
                        nota3 = Int32.Parse(linea3);

                        Console.Write("Ingrese calificacion 4: ");
                        string linea4 = Console.ReadLine();
                        nota4 = Int32.Parse(linea4);

                        Console.Write("Ingrese calificacion de examen: ");
                        string linea5 = Console.ReadLine();
                        examen = Int32.Parse(linea5);


                        Notas nuevaNota = new Notas(alumno,codClase);
                        nuevaNota.AgregarNotas(nota1,nota2,nota3,nota4,examen);

                        if (nuevaNota.NotaFinal<=100)
                        {
                            ListadeNotas.Add(nuevaNota);
                            Console.WriteLine("La nota final del alumno(a) " + alumno.Alumno.Nombres + " " + alumno.Alumno.Apellidos  + "es: " + nuevaNota.NotaFinal);
                        }
                        else
                        {
                            
                        }                        

            }
         Console.ReadLine();    
            

    }
    
    
        
}