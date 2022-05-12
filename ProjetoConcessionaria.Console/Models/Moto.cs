namespace ProjetoConcessionaria.Models
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }

        public Moto()
        {

        }
        public Moto(string marca, string modelo, string ano, int quilometragem, string cor, double valor,
                     int cilindrada, string partida) : base(marca, modelo, ano, quilometragem, cor, valor)
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
        public void SetPartida(string partida)
        {
            Partida = partida;
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