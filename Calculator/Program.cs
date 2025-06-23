namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção: ");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;

        }
    }

    static void Soma()
    {
        Console.Clear(); // limpa a tela antes de iniciar a aplicação;
        Console.WriteLine("Primeiro valor: "); // mensagem para o usuário;
        float v1 = float.Parse(Console.ReadLine()); // float pois o usuário pode digitar um número quebrado, lembrando que o console retorna uma string então deve-se fazer a conversão com parse o Readline espera o usuário dar um enter;

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

        Console.WriteLine(" ");// pula uma linha
        Console.WriteLine(" O resultadoda soma de " + v1 + " + " + v2 + $" é de {resultado}"); // concatena em string {interpolação de string}
                                                                                               // Console.WriteLine(" O resultadoda soma de " + v1 + " + " + v2 + $" é de {v1 + v2}");
        Console.ReadKey(); // pra ele simplemente não sair da tela

        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine(" O resultado da subtração de " + v1 + " - " + v2 + " é de " + (v1 - v2));
        Console.ReadKey(); // pra ele simplemente não sair da tela

        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine(" O resultadoda divisão de " + v1 + " / " + v2 + " é de " + resultado);

        Console.ReadKey();

        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação de {v1} * {v2} é: {resultado} ");

        Console.ReadKey();

        Menu();
    }
}