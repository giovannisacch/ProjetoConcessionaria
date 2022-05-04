using Xunit;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.TesteUnitario;

public class PessoaTest
{
    [Fact]
    public void TestarGetESetDeNome()
    {
        //Arrange
        var nomeEsperado = "Luiz";
        var pessoa = new Pessoa(nomeEsperado, "11111111111", "30/04/1998");

        //Act
        var nomeAtual = pessoa.GetNome();

        //Assert
        Assert.Equal(nomeEsperado, nomeAtual);
    }

    [Fact]
    public void TestarGetESetDeCpf()
    {
        //Arrange
        var cpfEsperado = "12345678901";
        var pessoa = new Pessoa("Luiz", cpfEsperado, "30/04/1998");

        //Act
        var cpfAtual = pessoa.GetCpf();

        //Assert
        Assert.Equal(cpfEsperado, cpfAtual);
    }

    [Fact]
    public void TestarGetESetDeDataNascimento()
    {
        //Arrange
        var dataEsperada = "30/04/1998";
        var pessoa = new Pessoa("Luiz", dataEsperada, "30/04/1998");

        //Act
        var dataAtual = pessoa.GetDataNacimento();

        //Assert
        Assert.Equal(dataEsperada, dataAtual.ToString("dd/MM/yyyy"));
    }
}