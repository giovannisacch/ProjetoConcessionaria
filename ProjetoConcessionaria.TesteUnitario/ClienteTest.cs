using Xunit;
using ProjetoConcessionaria.Lib.Exceptions;
using ProjetoConcessionaria.Lib.Models;

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

    [Fact]
    public void TelefoneNaoPodeTerMenosDeOitoDigitos()
    {
        //Arrange
        var telefoneEsperado = "1234567";

        //Act e Assert
        var exception = Assert.Throws<ErroDeValidacaoException>(() => new Cliente("Luiz", telefoneEsperado, "30/04/1998", "teste@gmail.com", telefoneEsperado));
        Assert.Equal("Telefone tem que ter entre 8 e 15 dígitos!", exception.Message);
    }

    [Fact]
    public void TelefoneNaoPodeTerMaisDeQuizeDigitos()
    {
        //Arrange
        var telefoneEsperado = "(11)01234-567899";

        //Act e Assert
        var exception = Assert.Throws<ErroDeValidacaoException>(() => new Cliente("Luiz", telefoneEsperado, "30/04/1998", "teste@gmail.com", telefoneEsperado));
        Assert.Equal("Telefone tem que ter entre 8 e 15 dígitos!", exception.Message);
    }

    [Fact]
    public void EmailTemQueTerArroba()
    {
        //Arrange
        var emailEsperado = "testegmail.com";

        //Act e Assert
        var exception = Assert.Throws<ErroDeValidacaoException>(() => new Cliente("Luiz", "444-555-444-45", "30/04/1998", emailEsperado, "4444-5555"));
        Assert.Equal("Digite um e-mail válido!", exception.Message);
    }


}
