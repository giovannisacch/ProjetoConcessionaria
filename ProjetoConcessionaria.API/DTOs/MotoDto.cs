namespace ProjetoConcessionaria.API.DTOs
{
    public class MotoDto : VeiculoDto
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }
    }
}