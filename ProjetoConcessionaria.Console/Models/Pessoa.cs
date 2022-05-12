namespace ProjetoConcessionaria.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }
        
        public Pessoa(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetDataNascimento(dataNascimento);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetDataNascimento(string dataNascimento)
        {
            DataNascimento = DateTime.Parse(dataNascimento);
        }

        public DateTime GetDataNacimento()
        {
            return DataNascimento;
        }
    }
}