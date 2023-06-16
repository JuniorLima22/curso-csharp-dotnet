
class Program
{
    static void Main(string[] args)
    {
        // int[] n = new int[10];
        Carro[] carros = new Carro[2];
        carros[0].marca = "Chevrolet";
        carros[0].modelo = "Classic";
        carros[0].cor = "Bege";

        carros[1].marca = "Honda";
        carros[1].modelo = "Civic";
        carros[1].cor = "Preto";
        
        // carros[0].info();
        // carros[1].info();

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].info();
        }

        int[] original = new int[] { 2, 5, 3, 8, 9, 12, 15, 7 };

        original.ToList().ForEach(
            p => Console.Write(p.ToString() + ", ")
        );
    }
}

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public void info()
    {
        System.Console.WriteLine("Marca.: {0}", this.marca);
        System.Console.WriteLine("Modelo: {0}", this.modelo);
        System.Console.WriteLine("Cor...: {0}", this.cor);
        System.Console.WriteLine("------------------");
    }
}
