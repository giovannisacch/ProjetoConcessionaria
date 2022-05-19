using ProjetoConcessionaria.Lib.Models;
using Xunit;
namespace ProjetoConcessionaria.TesteUnitario;

public class FuncionarioTest
{
    [Fact]
    public void TestarGetESetDeCargo()
    {
        //Arrange
        var cargoEsperado = "Vendedor";
        var funcionario = new Funcionario("Luiz", "11111111111", "30/04/1998", cargoEsperado);

        //Act
        var cargoAtual = funcionario.GetCargo();

        //Assert
        Assert.Equal(cargoEsperado, cargoAtual);
    }

}
