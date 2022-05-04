using Xunit;
namespace ProjetoConcessionaria.Models;

public class CarroTest
{

    [Fact]
    public void TestarGetESetDeTransmissaoAutomatica()
    {
        //Arrange
        var valorEsperado = true;
        var veiculo = new Carro("1", "1", "01/01/2022", 0, "1", 1, valorEsperado, "1");

        //Act
        var valorAtual = veiculo.GetTransmissaoAutomatica();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeCombustivel()
    {
        //Arrange
        var valorEsperado = "Gasolina";
        var veiculo = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, valorEsperado);

        //Act
        var valorAtual = veiculo.GetCombustivel();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarSeCalcValorFuncionaCorretamente()
    {
        //Arrange
        var valorEsperado = 120;
        var veiculo = new Carro("1", "1", "01/01/2022", 0, "1", 100, true, "Gasolina");

        //Act
        var valorAtual = veiculo.CalcValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

}