namespace ProjetoConcessionaria.Models
{
    public class Carro : Veiculo
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }

        public Carro()
        {

        }
        public Carro(string marca, string modelo, string ano, int quilometragem, string cor, double valor,
                     bool transmissaoAutomatica, string combustivel) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetTransmissaoAutomatica(transmissaoAutomatica);
            SetCombustivel(combustivel);
        }

        public void SetTransmissaoAutomatica(bool transmissaoAutomatica)
        {
            TransmissaoAutomatica = transmissaoAutomatica;
        }
        public bool GetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }
        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }
        public string GetCombustivel()
        {
            return Combustivel;
        }
        public override double CalcValor()
        {
            if (TransmissaoAutomatica)
            {
                return Valor = Valor * 1.2;
            }
            return Valor;
        }

    }
}