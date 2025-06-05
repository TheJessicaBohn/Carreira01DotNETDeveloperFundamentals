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

        // instaciando uma struct de forma vazia
        var mouse = new Product();

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);

        // instaciando uma struct de com parâmetros
        Product mouseGamer = new Product(1, "Mouse Gamer", 100.50, EProductType.Product);
        var manutencaoEletrica = new Product(2, "Manutenção Elétrica Residencial", 500, EProductType.Service);
        // sobrescrevendo a propriedade:
        mouseGamer.Id = 55;

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);
        Console.WriteLine(mouse.Type);
        Console.WriteLine((int)mouse.Type);

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

    struct Product
    {
        // Método construtor
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolas(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}