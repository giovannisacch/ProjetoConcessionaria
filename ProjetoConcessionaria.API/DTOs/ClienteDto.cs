namespace ProjetoConcessionaria.API.DTOs
{
    public class ClienteDto : PessoaDto
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}