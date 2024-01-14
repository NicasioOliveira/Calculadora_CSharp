using System.Security.AccessControl;
using Calculadora.Services;

Console.WriteLine("Escolha a operação desejada: ");
Console.WriteLine("1 - Adição ");
Console.WriteLine("2 - Subtração ");
Console.WriteLine("3 - Multiplicação ");
Console.WriteLine("4 - Divisão \n");

CalculadoraImplementada c = new CalculadoraImplementada();
int operacao = int.Parse(Console.ReadLine());

Console.WriteLine("Primeiro Número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Segundo Número");
int num2 = int.Parse(Console.ReadLine());

switch (operacao)
{
    case 1:
    {
        int resultado = c.Adicao(num1, num2);
        Console.WriteLine($"A soma dos números {num1} e {num2} resulta no número: {resultado}");
        break;
    }

    case 2:
    {
        int resultado = c.Subtracao(num1, num2);
        Console.WriteLine($"A subtração dos números {num1} e {num2} resulta no número: {resultado}");
        break;
    }

    case 3:
    {
        int resultado = c.Multiplicacao(num1, num2);
        Console.WriteLine($"A multiplicação dos números {num1} e {num2} resulta no número: {resultado}");
        break;
    }

    case 4:
    {
        int resultado = c.Divisao(num1, num2);
        Console.WriteLine($"A divisão dos números {num1} e {num2} resulta no número: {resultado}");
        break;
    }

    default:
    Console.WriteLine("Número de operação invalida, digite outro número");
    break;

}

