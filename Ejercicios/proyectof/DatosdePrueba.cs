using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListaProductos { get; set; }
    public List<Acreedor> ListadeAcreedores{ get; set; }
    public List<Proveedor> ListadeProveedores { get; set; }
    public List<Factura> ListaFacturas { get; set; }

    public DatosdePrueba()
    {
        ListaProductos = new List<Producto>();
        cargarProductos();

        ListadeAcreedores = new List<Acreedor>();
        cargarAcreedores();

        ListadeProveedores = new List<Proveedor>();
        cargarProveedores();

        ListaFacturas = new List<Factura>();

    }
     private void cargarProductos()
     {
         Producto P1 = new Producto(1,"Azucar",210);
         ListaProductos.Add(P1);
         Producto P2 = new Producto(2,"Harina",500);
         ListaProductos.Add(P2);
         Producto P3 = new Producto(3,"Manteca",100);
         ListaProductos.Add(P3);
         Producto P4 = new Producto(4,"Aceite",400);
         ListaProductos.Add(P4);
         Producto P5 = new Producto(5,"Carnes",600);
         ListaProductos.Add(P5);
         Producto P6 = new Producto(6,"Leche",700);
         ListaProductos.Add(P6);

    } 
    private void cargarAcreedores()
    {
        Acreedor a1= new Acreedor(1,"Pulperia Fanny","1466");
        ListadeAcreedores.Add(a1);
        Acreedor a2= new Acreedor(2,"Bodega HF","1588");
        ListadeAcreedores.Add(a2);
        Acreedor a3= new Acreedor(3,"Abarroteria","1699");
        ListadeAcreedores.Add(a3);
    } 
    private void cargarProveedores()
    {
        Proveedor V1 = new  Proveedor(1,"MolinoHarinero","V100");
        ListadeProveedores.Add(V1);
         Proveedor V2 = new  Proveedor(2,"Maseca","V201");
        ListadeProveedores.Add(V2);
         Proveedor V3 = new  Proveedor(3,"Insa","V300");
        ListadeProveedores.Add(V3);
         Proveedor V4 = new  Proveedor(4,"HarinaGallo","V301");
        ListadeProveedores.Add(V4);
    } 
    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("===================");
        Console.WriteLine("");

        foreach (var Producto in ListaProductos)
        {
           Console.WriteLine(Producto.Codigo + " | " + Producto.Descripcion + " | " + Producto.Precio); 
        }
        Console.ReadLine();
    } 
    public void ListarAcreedores()
    {
       Console.Clear();
        Console.WriteLine("Lista de Acreedores");
        Console.WriteLine("===================");
        Console.WriteLine(""); 

        foreach (var Acreedor in ListadeAcreedores)
    {
        Console.WriteLine(Acreedor.Codigo + " | " + Acreedor.Nombre + " | " + Acreedor.Telefono);
    }
        Console.Read();
    }
    public void ListarProveedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Proveedores");
        Console.WriteLine("===================");
        Console.WriteLine("");

        foreach (var proveedor in ListadeProveedores)
        {
            Console.WriteLine(proveedor.Codigo + " | " + proveedor.Nombre + " | " + proveedor.CodigoProveedor );
        }
        Console.Read();
    }
    public void CrearFacturas()
    {
       Console.WriteLine("Creando Factura");
        Console.WriteLine("=============");
        Console.WriteLine("");
         
        Console.WriteLine("Ingrese el Codigo del Acreedor");
        string CodigoAcreedor = Console.ReadLine();
      
        Acreedor acreedor = ListadeAcreedores.Find(C =>C.Codigo.ToString() == CodigoAcreedor);

         if (acreedor == null)
        {
            Console.WriteLine("Acreedor no encontrado");
            Console.ReadLine();
            return;
        }else
        {
            Console.WriteLine("Acreedor:" + acreedor.Nombre);
            Console.WriteLine("");
        }  
            Console.WriteLine("Ingrese el Codigo del Proveedor");
        string codigoProveedor = Console.ReadLine();
        Proveedor proveedor = ListadeProveedores.Find(V =>V.Codigo.ToString() ==   codigoProveedor);
        if (proveedor == null)
        {
           Console.WriteLine("Proveedor no encontrado");
           Console.ReadLine();
           return;
        } else{
            Console.WriteLine("Proveedor:" + proveedor.Nombre);
            Console.WriteLine("");
        }
        int nuevoCodigo = ListaFacturas.Count + 1; 
        Factura nuevaFactura = new Factura(nuevoCodigo, DateTime.Now,"SPS"+ nuevoCodigo, acreedor, proveedor);
        ListaFacturas.Add(nuevaFactura);

        while (true)
        {
            Console.WriteLine("Ingrese el Producto:");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListaProductos.Find(P =>P.Codigo.ToString() == codigoProducto);
           if (producto == null)
          {
            Console.WriteLine("Producto no encontrado");
           Console.ReadLine();
        }else{
            Console.WriteLine("Producto agregado:" + producto.Descripcion + " con precio de:" + producto.Precio);
            nuevaFactura.AgregarProducto(producto);
        }
           Console.WriteLine("Desea Continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                    break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Total de la Factura es:" + nuevaFactura.Total);
        Console.ReadLine();
        Console.WriteLine("Subtotal de su  Factura es:" + nuevaFactura.Total);
        Console.ReadLine();
        Console.WriteLine("Impuesto de la Factura es:" + nuevaFactura.Impuesto);
        Console.ReadLine();
        Console.WriteLine("Reporte de la Factura es:" + nuevaFactura.Reporte);
        Console.ReadLine();    
    } 

     public  void ListarFacturas()
    {	
        Console.WriteLine("Lista de Facturas");
        Console.WriteLine("================");
        Console.WriteLine(""); 
        Console.WriteLine ( " Codigo  |  Fecha  |  Total de factura " );
        Console.WriteLine ( " Acreedor |  Proveedor " );
        Console.WriteLine ( " ====================== " );
        Console.WriteLine ( " " );  

        foreach (var factura in ListaFacturas)
    {
            Console.WriteLine(factura.Codigo + " | "  + factura.Fecha + " | " + factura.Total); 
            Console.WriteLine(factura.Acreedor.Nombre + " | " + factura.Proveedor.Nombre ); 
        foreach (var detalle in factura.ListaFacturaDetalle)   
        {
            Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
        }
            Console.WriteLine();
        }
            Console.ReadLine();
    } 
    public void ListarReporte()
    {
        Console.WriteLine("Lista de Reporte");
        Console.WriteLine("================");
        Console.WriteLine(""); 
        Console.WriteLine ( "Codigo |  Fecha   |    Total   |    Acreedor  |   Proveedor  |   Impuesto  |   Subtotal " );
        Console.WriteLine("==========================================================================================");
        foreach (var Reporte in ListaFacturas)
        {
           Console.WriteLine(Reporte.Codigo + " | " + Reporte.Fecha + " | " + Reporte.Total + " | " + Reporte.Acreedor.Nombre + " | " + Reporte.Proveedor.Nombre + " | " + Reporte.Impuesto + " | " + Reporte.Subtotal);  
        }
        Console.ReadLine();
    }
}