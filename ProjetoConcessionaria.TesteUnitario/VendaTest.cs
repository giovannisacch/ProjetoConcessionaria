using Xunit;
namespace ProjetoConcessionaria.Models;

public class VendaTest
{
    [Fact]
    public void TestarGetESetDeCliente()
    {
        //Arrange
        var carroParametro = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var vendedorParametro = new Funcionario("1", "1", "01/01/0001", "1");
        var valorEsperado = new Cliente("1", "1", "01/01/0001", "1", "1");
        var venda = new Venda(valorEsperado, vendedorParametro, carroParametro, "1", 1);

        //Act
        var valorAtual = venda.GetCliente();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }
    [Fact]
    public void TestarGetESetDeVendedor()
    {
        //Arrange
        var carroParametro = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var valorEsperado = new Funcionario("1", "1", "01/01/0001", "1");
        var clienteParametro = new Cliente("1", "1", "01/01/0001", "1", "1");
        var venda = new Venda(clienteParametro, valorEsperado, carroParametro, "1", 1);

        //Act
        var valorAtual = venda.GetVendedor();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeVeiculo()
    {
        //Arrange
        var valorEsperado = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var vendedorParametro = new Funcionario("1", "1", "01/01/0001", "1");
        var clienteParametro = new Cliente("1", "1", "01/01/0001", "1", "1");
        var venda = new Venda(clienteParametro, vendedorParametro, valorEsperado, "1", 1);

        //Act
        var valorAtual = venda.GetVeiculo();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeFormaPagamento()
    {
        //Arrange
        var carroParametro = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var vendedorParametro = new Funcionario("1", "1", "01/01/0001", "1");
        var clienteParametro = new Cliente("1", "1", "01/01/0001", "1", "1");
        var valorEsperado = "Debito";
        var venda = new Venda(clienteParametro, vendedorParametro, carroParametro, valorEsperado, 1);

        //Act
        var valorAtual = venda.GetFormaPagamento();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarGetESetDeValorFInal()
    {
        //Arrange
        var carroParametro = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var vendedorParametro = new Funcionario("1", "1", "01/01/0001", "1");
        var clienteParametro = new Cliente("1", "1", "01/01/0001", "1", "1");
        var valorEsperado = 200000;
        var venda = new Venda(clienteParametro, vendedorParametro, carroParametro, "1", valorEsperado);

        //Act
        var valorAtual = venda.GetValorFinal();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

    [Fact]
    public void TestarSeAplicarDescontoFuncionaCorretamente()
    {
        //Arrange
        var carroParametro = new Carro("1", "1", "01/01/2022", 0, "1", 1, true, "1");
        var vendedorParametro = new Funcionario("1", "1", "01/01/0001", "Gerente");
        var clienteParametro = new Cliente("1", "1", "01/01/0001", "1", "1");
        var valorEsperado = 95;
        var venda = new Venda(clienteParametro, vendedorParametro, carroParametro, "1", 100);

        //Act
        venda.AplicarDesconto();
        var valorAtual = venda.GetValorFinal();

        //Assert
        Assert.Equal(valorEsperado, valorAtual);
    }

}