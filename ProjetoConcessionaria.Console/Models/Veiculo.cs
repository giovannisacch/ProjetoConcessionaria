namespace ProjetoConcessionaria.Models
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private int Kilometragem { get; set; }
        private string Cor { get; set; }
        protected double Valor { get; set; }

        public Veiculo(string marca, string modelo, string ano, int kilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetKilometragem(kilometragem);
            SetCor(cor);
            SetValor(valor);
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetMarca()
        {
            return Marca;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string GetModelo()
        {
            return Modelo;
        }
        public void SetAno(string ano)
        {
            Ano = DateTime.Parse(ano);
        }
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetKilometragem(int kilometragem)
        {
            Kilometragem = kilometragem;
        }
        public int GetKilometragem()
        {
            return Kilometragem;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }
        public string GetCor()
        {
            return Cor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public double GetValor()
        {
            return Valor;
        }

        public virtual double CalcValor()
        {
            return Valor;
        }
    }
}