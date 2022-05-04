using Xunit;
namespace ProjetoConcessionaria.Models;

public class MotoTest
{

    [Fact]
    public void TestarGetESetDeCilindrada()
    {
        //Arrange
        var valorEsperado = 250;
        var veiculo = new Moto("1", "1", "01/01/2022", 0, "1", 1, valorEsperado, "1");

        //Act
        var valorAtual = veiculo.GetCilindrada();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDePartida()
    {
        //Arrange
        var valorEsperado = "Carburador";
        var veiculo = new Moto("1", "1", "01/01/2022", 0, "1", 1, 1, valorEsperado);

        //Act
        var valorAtual = veiculo.GetPartida();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarSeCalcValorFuncionaCorretamente()
    {
        //Arrange
        var valorEsperado = 5610;
        var veiculo = new Moto("1", "1", "01/01/2022", 0, "1", 100, 100, "Eletronica");

        //Act
        var valorAtual = veiculo.CalcValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

}