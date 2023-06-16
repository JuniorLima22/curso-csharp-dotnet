using System;

public class Program
{
    public static void Main()
    {
        Carro c1 = new Carro();
        c1[2];
        Console.WriteLine("Velocidade: {0}", c1[2]);
    }
}

public class Carro
{
    public int[] velMax = new int[5] { 80, 120, 160, 240, 300 };
    public int this[int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if (value > 300) {
                velMax[i] = 0;
            } else if (value > 300) {
                velMax[i] = 300;
            } else {
                velMax[i] = value;
            }
        }
    }
}