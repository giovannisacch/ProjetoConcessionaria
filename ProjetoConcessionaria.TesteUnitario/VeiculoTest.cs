using Xunit;
namespace ProjetoConcessionaria.Models;

public class VeiculoTest
{
    [Fact]
    public void TestarGetESetDeMarca()
    {
        //Arrange
        var marcaEsperada = "Ferrari";
        var veiculo = new Veiculo(marcaEsperada, "1", "1/1/2022", 1, "1", 1);

        //Act
        var marcaAtual = veiculo.GetMarca();

        //Assert
        Assert.Equal(marcaEsperada, marcaAtual);
    }
    [Fact]
    public void TestarGetESetDeModelo()
    {
        //Arrange
        var modeloEsperado = "F8";
        var veiculo = new Veiculo("1", modeloEsperado, "1/1/2022", 1, "1", 1);

        //Act
        var modeloAtual = veiculo.GetModelo();

        //Assert
        Assert.Equal(modeloEsperado, modeloAtual);
    }

    [Fact]
    public void TestarGetESetDeAno()
    {
        //Arrange
        var anoEsperado = "01/01/2022";
        var veiculo = new Veiculo("1", "1", anoEsperado, 1, "1", 1);

        //Act
        var anoAtual = veiculo.GetAno();

        //Assert
        Assert.Equal(anoEsperado, anoAtual.ToString("dd/MM/yyyy"));
    }

    [Fact]
    public void TestarGetESetDeQuilometragem()
    {
        //Arrange
        var quilometragemEsperada = 0;
        var veiculo = new Veiculo("1", "1", "01/01/2022", quilometragemEsperada, "1", 1);

        //Act
        var quilometragemAtual = veiculo.GetQuilometragem();

        //Assert
        Assert.Equal(quilometragemEsperada, quilometragemAtual);
    }

    [Fact]
    public void TestarGetESetDeCor()
    {
        //Arrange
        var corEsperada = "Vermelho";
        var veiculo = new Veiculo("1", "1", "01/01/2022", 0, corEsperada, 1);

        //Act
        var corAtual = veiculo.GetCor();

        //Assert
        Assert.Equal(corEsperada, corAtual);
    }

    [Fact]
    public void TestarGetESetDeValor()
    {
        //Arrange
        var valorEsperado = 200000;
        var veiculo = new Veiculo("1", "1", "01/01/2022", 0, "1", valorEsperado);

        //Act
        var valorAtual = veiculo.GetValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeCalcValor()
    {
        //Arrange
        var valorEsperado = 200000;
        var veiculo = new Veiculo("1", "1", "01/01/2022", 0, "1", valorEsperado);

        //Act
        var valorAtual = veiculo.CalcValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

}