namespace CalculadoraTestes;
using Calculadora.services;
public class UnitTest1
{
    public CalculadoraT construirClasse()
    {

        CalculadoraT calc = new CalculadoraT("01/03/2024");
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestarSomar(int valor1, int valor2, int resultado)
    {
        CalculadoraT calc = construirClasse();
        int resultadoCalculadora = calc.Somar(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(6, 3, 3)]
    public void TestarSubtrair(int valor1, int valor2, int resultado)
    {
        CalculadoraT calc = construirClasse();
        int resultadoCalculadora = calc.Subtrair(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 5, 10)]
    public void TestarMultiplicar(int valor1, int valor2, int resultado)
    {
        CalculadoraT calc = construirClasse();
        int resultadoCalculadora = calc.Multiplicar(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(8, 2, 4)]
    public void TestarDividir(int valor1, int valor2, int resultado)
    {
        CalculadoraT calc = construirClasse();
        int resultadoCalculadora = calc.Dividir(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestatDivisaoPorZero()
    {
        CalculadoraT calc = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }


    [Fact]
    public void TestarHistorico()
    {
        CalculadoraT calc = construirClasse();

        calc.Somar(1, 2);
        calc.Somar(4, 2);
        calc.Somar(5, 3);
        calc.Somar(4, 2);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}