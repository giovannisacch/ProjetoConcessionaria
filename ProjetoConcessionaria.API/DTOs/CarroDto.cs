namespace ProjetoConcessionaria.API.DTOs
{
    public class CarroDto : VeiculoDto
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }

    }
}