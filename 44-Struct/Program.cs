class Program
{
    static void Main(string[] args)
    {
        Carro c1;

        c1.marca = "Chevrolet";
        c1.modelo = "Classic";
        c1.cor = "Bege";
        c1.info();

        System.Console.WriteLine("--------------------");

        Carro c2 = new Carro("Honda", "Civic", "Preto");
        c2.info();
    }
}

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        System.Console.WriteLine("Marca.: {0}", this.marca);
        System.Console.WriteLine("Modelo: {0}", this.modelo);
        System.Console.WriteLine("Cor...: {0}", this.cor);
    }
}
