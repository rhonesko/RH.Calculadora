// See https://aka.ms/new-console-template for more informatio

Menu();



static void Menu()
{
    Console.WriteLine(" ");
    Console.WriteLine("//////////////////////////// ");
    Console.WriteLine("Bem vindo á uma calculadora!");
    Console.WriteLine("  ");
    Console.WriteLine("Por favor escolha um número entre 1 e 5 ;");
    Console.WriteLine("");
    Console.WriteLine("Sendo que 1 é Soma;");
    Console.WriteLine("Sendo que 2 é Subtração;");
    Console.WriteLine("Sendo que 3 é Divisão;");
    Console.WriteLine("Sendo que 4 é Multiplicação;");
    Console.WriteLine("Sendo que 5 se quiser Sair; ");

    Console.WriteLine("");
    float escolha = float.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Console.WriteLine("ATENÇÃO o número tem que ser entre 1 e 4 !!!!"); break;
    }
    Menu();
}




static void Soma()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a função SOMA");
    Console.WriteLine("");

    Console.WriteLine("Digite um número: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    Console.WriteLine($"O resultado da Soma é: {resultado} ");
    Menu();
}


static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a função SUBTRAÇÃO");
    Console.WriteLine("");

    Console.WriteLine("Digite um número: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;
    Console.WriteLine($"O resultado da Subtração é: {resultado} ");
    Menu();
}


static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a função Divisão");
    Console.WriteLine("");

    Console.WriteLine("Digite um número: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;
    Console.WriteLine($"O resultado da Divisão é: {resultado} ");
    Menu();
}


static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a função Multiplicação");
    Console.WriteLine("");

    Console.WriteLine("Digite um número: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;
    Console.WriteLine($"O resultado da Multiplicação é: {resultado} ");
    Menu();
}