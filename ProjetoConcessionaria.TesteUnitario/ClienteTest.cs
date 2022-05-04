using Xunit;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.TesteUnitario;

public class ClienteTest
{
    [Fact]
    public void TestarGetESetDeEmail()
    {
        //Arrange
        var emailEsperado = "teste@gmail.com";
        var cliente = new Cliente("Luiz", "11111111111", "30/04/1998", emailEsperado, "111111111");

        //Act
        var emailAtual = cliente.GetEmail();

        //Assert
        Assert.Equal(emailEsperado, emailAtual);
    }

    [Fact]
    public void TestarGetESetDeTelefone()
    {
        //Arrange
        var telefoneEsperado = "4002-8922";
        var cliente = new Cliente("Luiz", "1345678945", "30/04/1998", "teste@gmail.com", telefoneEsperado);

        //Act
        var telefoneAtual = cliente.GetTelefone();

        //Assert
        Assert.Equal(telefoneEsperado, telefoneAtual);
    }


}