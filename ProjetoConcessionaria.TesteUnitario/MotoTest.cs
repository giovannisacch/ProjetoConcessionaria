using Xunit;
namespace ProjetoConcessionaria.Models;

public class MotoTest
{

    [Fact]
    public void TestarGetESetDeCilindrada()
    {
        //Arrange
        var valorEsperado = 250;
        var veiculo = CriarMotoPadrao();

        //Act
        veiculo.SetCilindrada(valorEsperado);
        var valorAtual = veiculo.GetCilindrada();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDePartida()
    {
        //Arrange
        var valorEsperado = "Carburador";
        var veiculo = CriarMotoPadrao();

        //Act
        veiculo.SetPartida(valorEsperado);
        var valorAtual = veiculo.GetPartida();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarSeCalcValorFuncionaCorretamente()
    {
        //Arrange
        var valorEsperado = 35200;
        var veiculo = CriarMotoPadrao();

        //Act
        var valorAtual = veiculo.CalcValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    public Moto CriarMotoPadrao()
    {
        return new Moto("Teste", "Teste", "01/01/2022", 0, "Vermelho", 2000, 600, "Eletronica");
    }

}