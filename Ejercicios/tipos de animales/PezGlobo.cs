using System;

public class PezGlobo: Peces
{
    public string Piel { get; set; }

    public void Incharse()
    {
        Console.WriteLine("Incharse como pelota");
    }

    public void Venenosa()
    {
        SonVenenosa();
    }

    private void SonVenenosa()
    {
        Console.WriteLine("Son Venenosas a pesar que se ven inofensivas ");
    }
}