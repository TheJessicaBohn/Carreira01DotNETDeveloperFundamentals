namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // limpa a tela antes de iniciar a aplicação;
        Console.WriteLine("Primeiro valor: "); // mensagem para o usuário;
        float v1 = float.Parse(Console.ReadLine()); // float pois o usuário pode digitar um número quebrado, lembrando que o console retorna uma string então deve-se fazer a conversão com parse o Readline espera o usuário dar um enter;

        Console.WriteLine(v1); //Exibe valor na tela
    }
}