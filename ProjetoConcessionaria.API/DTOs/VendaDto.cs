using ProjetoConcessionaria.Lib.Models;

namespace ProjetoConcessionaria.API.DTOs
{
    public class VendaDto
    {
        public Cliente ClienteDto { get; set; }
        public Funcionario VendedorDto { get; set; }
        public Veiculo VeiculoDto { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}