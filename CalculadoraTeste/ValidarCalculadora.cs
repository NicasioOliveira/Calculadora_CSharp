using Calculadora.Services;

namespace CalculadoraTeste;

public class ValidarCalculadora
{
    private CalculadoraImplementada teste;

    public ValidarCalculadora()
    {
        teste = new CalculadoraImplementada();
    }
    [Fact]
    public void DeveSomarDoisNumeros()
    {
        //Arrange
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Act
        int resultado = teste.Adicao(num1, num2);

        //Assert
        Assert.Equal(num1 + num2, resultado);
    }
    [Fact]
    public void DeveSubtrairDoisNumeros()
    {
        //Arrange
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Act
        int resultado = teste.Subtracao(num1, num2);

        //Assert
        Assert.Equal(num1 - num2, resultado);
    }
    [Fact]
    public void DeveMultiplicarDoisNumeros()
    {
        //Arrange
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Act
        int resultado = teste.Multiplicacao(num1, num2);

        //Assert
        Assert.Equal(num1 * num2, resultado);
    }
    [Fact]
    public void DeveDividirDoisNumeros()
    {
        //Arrange
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Act
        int resultado = teste.Divisao(num1, num2);

        //Assert
        Assert.Equal(num1 / num2, resultado);
    }
}