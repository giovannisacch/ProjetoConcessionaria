using Xunit;
namespace ProjetoConcessionaria.Models;

public class VeiculoTest
{
    [Fact]
    public void TestarGetESetDeMarca()
    {
        //Arrange
        var marcaEsperada = "Ferrari";
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetMarca(marcaEsperada);
        var marcaAtual = veiculo.GetMarca();

        //Assert
        Assert.Equal(marcaEsperada, marcaAtual);
    }
    [Fact]
    public void TestarGetESetDeModelo()
    {
        //Arrange
        var modeloEsperado = "F8";
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetModelo(modeloEsperado);
        var modeloAtual = veiculo.GetModelo();

        //Assert
        Assert.Equal(modeloEsperado, modeloAtual);
    }

    [Fact]
    public void TestarGetESetDeAno()
    {
        //Arrange
        var anoEsperado = "01/01/2022";
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetAno(anoEsperado);
        var anoAtual = veiculo.GetAno();

        //Assert
        Assert.Equal(anoEsperado, anoAtual.ToString("dd/MM/yyyy"));
    }

    [Fact]
    public void TestarGetESetDeQuilometragem()
    {
        //Arrange
        var quilometragemEsperada = 0;
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetQuilometragem(quilometragemEsperada);
        var quilometragemAtual = veiculo.GetQuilometragem();

        //Assert
        Assert.Equal(quilometragemEsperada, quilometragemAtual);
    }

    [Fact]
    public void TestarGetESetDeCor()
    {
        //Arrange
        var corEsperada = "Vermelho";
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetCor(corEsperada);
        var corAtual = veiculo.GetCor();

        //Assert
        Assert.Equal(corEsperada, corAtual);
    }

    [Fact]
    public void TestarGetESetDeValor()
    {
        //Arrange
        var valorEsperado = 200000;
        var veiculo = CriarVeiculoPadrao();

        //Act
        veiculo.SetValor(valorEsperado);
        var valorAtual = veiculo.GetValor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    public Veiculo CriarVeiculoPadrao()
    {
        return new Veiculo("Teste", "Teste", "01/01/2022", 0, "Vermelho", 5000);
    }

}