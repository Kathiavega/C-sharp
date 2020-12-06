using System;

public class Mono: Mamifero
{
    public string Orden { get; set; }
    public string Reproduccion { get; set; }
    public bool SonSalvajes { get; set; }

   public Mono()
   {
      SonSalvajes = true;
   }

   public Mono(bool sonSalvaje)
   {
     SonSalvajes = sonSalvaje;   
   }
   public void Aullar()
   {
       Console.WriteLine("Ua ua ua");
   }
}