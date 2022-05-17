namespace ProjetoConcessionaria.API.DTOs
{
    public class Venda
    {
        public ClienteDto Cliente { get; set; }
        public FuncionarioDto Vendedor { get; set; }
        public VeiculoDto Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}