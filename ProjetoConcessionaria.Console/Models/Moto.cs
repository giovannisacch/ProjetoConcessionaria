namespace ProjetoConcessionaria.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }

        public Moto(string marca, string modelo, string ano, int kilometragem, string cor, double valor,
                     int cilindrada, string partida) : base(marca, modelo, ano, kilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }

        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetPartida(string Partida)
        {
            Partida = Partida;
        }
        public string GetPartida()
        {
            return Partida;
        }
        public virtual double CalcValor()
        {
            var valor = Valor + (Cilindrada * 50);
            if (Partida == "Eletronica")
            {
                return Valor = valor * 1.1;
            }
            return Valor = valor;
        }
    }
}