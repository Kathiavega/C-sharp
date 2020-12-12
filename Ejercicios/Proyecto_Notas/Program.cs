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
            string usuario = "admin";
            string password = "1234";
            Console.Clear();    
            Console.WriteLine("===========Acceso al registro de calificaciones===========");
            Console.Write("Ingrese el usuario: ");
            usuario = Console.ReadLine();
            Console.Write("Ingrese password: ");
            password = Console.ReadLine();

            if (usuario == "admin" && password == "1234" )
            {
                Console.Clear();
                int cargar1 = 0, cargar2 = 0, stop = 100;
               

                while (cargar2 <= stop)
                {
                    Console.WriteLine("");
                    Console.SetCursorPosition(32, 1);
                    Console.WriteLine("Bienvenido");
                    Console.Write("CARGANDO % " + cargar2);
                    Thread.Sleep(1); 
                    cargar2++;


                    if (cargar1 < 80)
                    {
                    Console.SetCursorPosition(cargar1, 3);
                    Console.Write("█" );
                    Thread.Sleep(30);
                    }
                cargar1++;
                }

                string opcion = "";
                BasedeDatos datos = new BasedeDatos();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine(" __                         __                                      ");
                    Console.WriteLine("(_ . _|_ _  _  _    _| _   / _  _ _|_. _  _    _| _  |\\ | _ |_ _  _ ");
                    Console.WriteLine("__)|_)|_(- |||(_|  (_|(-   \\__)(-_)|_|(_)| )  (_|(-  | \\|(_)|_(_|_) ");
                    Console.WriteLine("");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("");
                    Console.WriteLine("                     1 - Lista de Alumnos");
                    Console.WriteLine("                     2 - Clases Disponibles");
                    Console.WriteLine("                     3 - Gestionar Alumno");
                    Console.WriteLine("                     4 - Matricular Clase");
                    Console.WriteLine("                     5 - Retirar Clase");
                    Console.WriteLine("                     6 - Ingresar Notas");
                    Console.WriteLine("                     0 - Salir");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Por favor, ingrese una opcion: ");
                    opcion = Console.ReadLine();
                    

                    switch (opcion)
                    {
                        case "1":
                        {           
                                
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("         Como desea realizar la busqueda?       ");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("1) Listar informacion general por Alumno(a)");
                            Console.WriteLine("");
                            Console.WriteLine("2) Listar Alumnos matriculados por clase");
                            Console.WriteLine("");
                            Console.WriteLine("3) Listar calificaciones por Alumno");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("");
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
                            Console.WriteLine("              Que desea realizar?               ");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("1) Ingresar Alumno(a)");
                            Console.WriteLine("");
                            Console.WriteLine("2) Eliminar registro de Alumno(a)");
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
                
                
            } else
            {
                Console.WriteLine("Usuario/Password incorrecto");
                Console.ReadLine();
            }   
            
            
        }///whileacceso

            
        }
    }
}
