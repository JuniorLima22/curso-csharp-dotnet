class Program
{
    public static void Main(string[] args)
    {

        string s = "Aula 02 - Variaveis";
        int i = 32;
        decimal d = 1.33m; // Utilizado para cálculos financeiro (Moeda)
        double d2 = 1.33; // Utilizado para cálculos cientificos e medições
        float f = 1.2f; // Engine de jogos como o unity devido a perfomance

        Console.WriteLine(s);
        Console.WriteLine("Inteiro: " + i);
        Console.WriteLine("Decimal: " + d + " -> Utilizado para cálculos financeiro (Moeda)");
        Console.WriteLine("Double: " + d2 + " -> Utilizado para cálculos cientificos e medições");
        Console.WriteLine("Float: " + f + " -> Engine de jogos como o unity devido a perfomance");
    }
}