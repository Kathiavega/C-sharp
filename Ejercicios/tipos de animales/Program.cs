using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            Console.WriteLine("-----");
            Console.WriteLine("Perro");
            Console.WriteLine("-----");
            p.Nombre = "channel";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("-----");
            Console.WriteLine("Gato");
            Console.WriteLine("-----");
            g.Nombre = "dreck";
            g.Patas = 4;
            g.Pelaje = "Pelo largo, blanco";
            g.Raza = "birmano";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsAmargado = true;

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);
            Console.WriteLine(g.Raza);         

            Console.WriteLine();

            Mono m = new Mono();
            Console.WriteLine("-----");
            Console.WriteLine("Mono");
            Console.WriteLine("-----");
            m.Nombre = "Tití de corona negra";
            m.Patas = 4;
            m.Orden = "Primates";
            m.Reproduccion = "son viviparo";
            m.Comer();
            m.SonSalvajes = true;
            m.Caminar();
            m.Aullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine(m.Orden);
            Console.WriteLine(m.Reproduccion);

            Console.WriteLine();

            Aguila a = new Aguila();
            Console.WriteLine("-----");
            Console.WriteLine("Aguila");
            Console.WriteLine("-----");
            a.Nombre = "loer";
            a.Patas = 2;
            a.Incubacion = 30 ;
            a.ColorPlumaje = "las alas son de color gris oscuro uniforme, presentan parches blancuzcos más cerca de la base";
            a.Volar();
            a.Comer();
            a.Cazadoras();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Incubacion);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Console.WriteLine();

            Loro l = new Loro();
            Console.WriteLine("-----");
            Console.WriteLine("Loro");
            Console.WriteLine("-----");
            l.Nombre = "bruno";
            l.Patas = 2;
            l.ColorPlumaje = "Verdoso";
            l.Comer();
            l.Volar();
            l.Hablan();
            l.Pico();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje);

            Console.WriteLine();

            PezGlobo z = new PezGlobo();
            Console.WriteLine("----------");
            Console.WriteLine("Pez Globo");
            Console.WriteLine("----------");
            z.Nombre = "chiquia";
            z.Piel = "suelen tener la piel áspera de punta";
            z.NumeroAletas = 2;
            z.Comer();
            z.Nadar();
            z.Color = "Amarillo y verdoso con manchas negras  ";
            z.Venenosa();
            z.Incharse();

            Console.WriteLine(z.Nombre);
            Console.WriteLine(z.NumeroAletas);
            Console.WriteLine(z.Piel);
            Console.WriteLine(z.Color);
            }
        }
}
