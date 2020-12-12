using System;
using System.Threading;

namespace proyecto_notas
{
    class Program
    {
        static void Main(string[] args)
        {        

            while (true)
        {
            
            Console.Clear();    
            
                string opcion = "";
                BasedeDatos datos = new BasedeDatos();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("  Sistema de notas escolares");
                    Console.WriteLine("----------------------------");

                    Console.WriteLine("1 - Lista de Alumnos");
                    Console.WriteLine("2 - Clases Disponibles");
                    Console.WriteLine("3 - Registro de Alumno");
                    Console.WriteLine("4 - Matricular Clase");
                    Console.WriteLine("5 - Retirar Clase");
                    Console.WriteLine("6 - Ingresar Notas");
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Por favor, ingrese una opcion: ");
                    opcion = Console.ReadLine();
                    

                    switch (opcion)
                    {
                        case "1":
                        {           
                                
                            Console.Clear();
                            Console.WriteLine("  Sistema de notas escolares");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("1- Ingreso de informacion general por Alumno(a)");
                            Console.WriteLine("");
                            Console.WriteLine("2- Ingreso de Alumnos matriculados por clase");
                            Console.WriteLine("");
                            Console.WriteLine("3-  Lista de calificaciones por Alumno");
                            Console.WriteLine("");
                            Console.Write("Ingrese una opcion: ");
                            string op2 = Console.ReadLine();

                            switch (op2)
                            {
                                case "1":
                                datos.ListarAlumnos();
                                    break;
                                case "2":
                                datos.ListarMatriculas();
                                    break;
                                case "3":
                                datos.ListarNotas();
                                    break;        
                                default:
                                break;
                            }
                            break;
                        }
                        case "2":
                            datos.ListarClases();
                            break; 
                        case "3":
                            {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("1-  Ingresar Alumno(a)");
                            Console.WriteLine("");
                            Console.WriteLine("2-  Eliminar registro de Alumno(a)");
                            Console.WriteLine("");
                            Console.Write("Ingrese una opcion: ");
                            string op3 = Console.ReadLine();

                            switch (op3)
                            {
                                case "1":
                                    datos.IngresarAlumno();
                                    break;
                                case "2":
                                    datos.ModificarAlumno();
                                    break;
                                default:
                                break;
                            }
                            
                            }
                            
                            break;     
                        case "4":
                            datos.MatriculaAlumno();
                            break; 
                        case "5":
                            datos.RetirarAlumno();
                            break;        
                        case "6":
                            datos.IngresarNotas();
                            break;
                        default:
                        break;
                    }

                    if (opcion == "0")
                    {
                        break;
                    }

                }
                
                
            } 
            
            
            
        }

            
        }
    }