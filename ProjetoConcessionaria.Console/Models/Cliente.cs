namespace ProjetoConcessionaria.Models
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, string dataNascimento, string email, string telefone) :
                       base(nome, cpf, dataNascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
    }
}