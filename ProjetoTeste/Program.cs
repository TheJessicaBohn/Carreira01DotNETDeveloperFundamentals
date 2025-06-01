namespace ProjetoTeste;

class Program
{
    static void Main(string[] args)
    {
        MeuMetodo();

        string nome = RetornaNome("Jéssica", "Bohn");
        Console.WriteLine(nome);

        VarivavelDeValor();

        VarivavelDeReferencia();
    }
    static void MeuMetodo()
    {
        Console.WriteLine("C# é legal");
    }

    static string RetornaNome(
        string nome,
        string sobrenome,
        int idade = 28
    )
    {
        return nome + " " + sobrenome + " tem " + idade.ToString() + " anos";
    }

    static void VarivavelDeValor()
    {
        int x = 25;
        int y = x; //y é uma cópia de x

        Console.WriteLine(x); //25
        Console.WriteLine(y); //25

        x = 32; //somente x foi alterado;

        Console.WriteLine(x); //32
        Console.WriteLine(y); //25
    }
    
    static void VarivavelDeReferencia()
    {
        var arr = new string[2];
        arr[0] = "Item 1";
        var arr2 = arr; //não cria uma cópia

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);
        
        // Altera as duas listas
        arr[0] = "Item Alterado";
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);
    }
}