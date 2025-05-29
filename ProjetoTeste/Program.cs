namespace ProjetoTeste;

class Program
{
    static void Main(string[] args)
    {
        MeuMetodo();

        string nome = RetornaNome("Jéssica", "Bohn");
        Console.WriteLine(nome);
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
}