using Xunit;
namespace ProjetoConcessionaria.Models;

public class CarroTest
{

    [Fact]
    public void TestarGetESetDeTransmissaoAutomatica()
    {
        //Arrange
        var valorEsperado = false;
        var veiculo = CriarCarroPadrao();

        //Act
        veiculo.SetTransmissaoAutomatica(valorEsperado);
        var valorAtual = veiculo.GetTransmissaoAutomatica();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeCombustivel()
    {
        //Arrange
        var valorEsperado = "Alcool";
        var veiculo = CriarCarroPadrao();

        //Act
        veiculo.SetCombustivel(valorEsperado);
        var valorAtual = veiculo.GetCombustivel();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarSeCalcValorFuncionaCorretamente()
    {
        //Arrange
        var valorEsperado = 6000;
        var veiculo = CriarCarroPadrao();

        //Act
        var valorAtual = veiculo.CalcValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    public Carro CriarCarroPadrao()
    {
        return new Carro("Teste", "Teste", "01/01/2022", 0, "Vermelho", 5000, true, "Gasolina");
    }

}