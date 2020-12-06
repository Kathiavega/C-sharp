using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsAmargado { get; set; }

    public Gato() // Polimorfismo
    {
        EsAmargado = true;
    }

    public Gato(bool esAmargado) // Polimorfismo
    {
        EsAmargado = esAmargado;
    }
    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");

    }

}