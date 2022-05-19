using ProjetoConcessionaria.Lib.Exceptions;

namespace ProjetoConcessionaria.Lib.Models
{
    public class Cliente : Pessoa
    {
        private string Email { get; set; }
        private string Telefone { get; set; }

        public Cliente(string nome, string cpf, string dataNascimento, string email, string telefone) :
                       base(nome, cpf, dataNascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }

        public void SetEmail(string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelefone(string telefone)
        {
            ValidarTelefone(telefone);
            Telefone = telefone;
        }
        public string GetTelefone()
        {
            return Telefone;
        }

        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length >= 8 && telefone.Length < 15)
                return true;
            throw new ErroDeValidacaoException("Telefone tem que ter entre 8 e 15 dígitos!");
        }

        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            throw new ErroDeValidacaoException("Digite um e-mail válido!");
        }
    }
}