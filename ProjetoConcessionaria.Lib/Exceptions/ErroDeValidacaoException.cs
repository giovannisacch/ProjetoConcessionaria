namespace ProjetoConcessionaria.Lib.Exceptions
{
   public class ErroDeValidacaoException : System.Exception
    {
        public ErroDeValidacaoException()
        {

        }
        public ErroDeValidacaoException(string message) : base(message)
        {

        }
    }
}