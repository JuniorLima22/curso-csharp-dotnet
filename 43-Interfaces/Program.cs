using System;

class Program
{
    static void Main(string[] args)
    {
        Carro c1 = new Carro();
        c1.ligar();
        c1.desligar();
        c1.info();
        c1.disparo();
    }
}

public interface IVeiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface ICombate
{
    void disparo();
}

class Carro : IVeiculo, ICombate
{
    private bool ligado;
    private int municao;
    public Carro()
    {
        Console.WriteLine("Construtor de Carro");
        setMunicao(150);
    }

    public void setMunicao(int value)
    {
        this.municao = value;
    }

    public void ligar()
    {
        Console.WriteLine("Ligar");
        this.ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("Desligar");
        this.ligado = false;
    }

    public void info()
    {
        Console.WriteLine("Info");
    }

    public void disparo()
    {
        Console.WriteLine("Disparo");
    }
}
