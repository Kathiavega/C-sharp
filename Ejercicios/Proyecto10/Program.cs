using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 
    class Program
    {
        static void Main(string[] args)
        {
            int PrecioM = 3000; int PrecioC = 4000; int PrecioB = 400; int PrecioT = 500;  int PrecioW = 1000; int sum = 0; int cant = 0; int importe = 0; int importe1 = 0; int importe2 = 0; int importe3 = 0; int importe4 = 0;

            Console.WriteLine("");
            Console.WriteLine("Mytec H.N. ");
            Console.WriteLine("Satisfaciendo las necesidades del cliente mayorista. ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("\n\nproducto");
            Console.WriteLine("Mytec H.N. ");

            Console.WriteLine("\nMonitor :  ");

             Console.WriteLine("Precio Monitor : 3000 ");     
             Console.WriteLine("Cantidad :  ");
             cant = Int32.Parse(Console.ReadLine());
                   
                   
             importe = cant * PrecioM;
             Console.WriteLine("Total : {0}", importe);
                   
   
            Console.WriteLine("\n\nproducto");
            Console.WriteLine("\nCPU :  ");
          

           
            Console.WriteLine("Precio CPU :4000 ");
               

             
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
               
               
            importe1 = cant * PrecioC;
            Console.WriteLine("Total : {0}", importe1);
               
         
            Console.WriteLine("\n\nArticulo3");
            Console.WriteLine("\nBocina :  ");
             

               
            Console.WriteLine("Precio Bocina : 400 ");
                   

                   
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
                   
            importe2 = cant * PrecioB;
            Console.WriteLine("Total : {0}", importe2);
           
            Console.WriteLine("\n\nArticulo4");
            Console.WriteLine("\nTeclado :  ");
              

               
            Console.WriteLine("Precio Teclado : 500 ");
                 

                   
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
            importe3 = cant * PrecioT;
            Console.WriteLine("Total : {0}", importe3);
                   
         
           
            Console.WriteLine("\n\nArticulo5");
            Console.WriteLine("\nWebcam :  ");
            

             
            Console.WriteLine("Precio Webcam : 500 ");
                   

            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
            importe4 = cant * PrecioW;
            Console.WriteLine("Total : {0}", importe4);
             
             double imp=0; double sumtotal=0;

            sum = importe + importe1 + importe2 + importe3 + importe4;
            imp = sum * 0.15;
            sumtotal =sum + imp;


           
            Console.WriteLine("\n\n\tEl Total a es de : {0}", sum);
            Console.WriteLine("\n\n\tSu impuesto es de : {0}", imp);
            Console.WriteLine("\n\n\tEl Total a pagar es de : {0}", sumtotal);

           
            Console.ReadKey();
        }
    }
}