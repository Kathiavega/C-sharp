using System;

namespace proyectof
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();

            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de facturacion");
                Console.WriteLine("======================");
                Console.WriteLine("");
                Console.WriteLine( "1. Lista de Productos");
                Console.WriteLine( "2. Crear Factura");
                Console.WriteLine( "3. Lista de Acreedores");
                Console.WriteLine( "4. Lista de Proveedores");
                Console.WriteLine( "5. Lista de Facturas");
                 Console.WriteLine("6. Listar Reporte");
                Console.WriteLine( "0. Avandonar Facturacion"); 
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearFacturas();
                        break;
                    case "3":
                        datos.ListarAcreedores();
                        break; 
                    case "4":
                        datos.ListarProveedores();
                        break;      
                    case "5":
                        datos.ListarFacturas();
                        break;
                    case "6":
                        datos.ListarReporte();
                        break;  
                    default:
                    break;
                }  
                if(opcion == "0"){
                    break;
                }       
            }

        }
    }
}
