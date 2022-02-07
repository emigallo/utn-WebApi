using System;
namespace Api.Exceptions
{
    public class UserInvalidException : Exception
    {
        public UserInvalidException(Exception ex = null) : base(ex?.Message)
        {
            this.MessageToShow = "Usuario inválido.";
        }

        public string MessageToShow { get; protected set; }
        public Boolean Log { get; set; }
    }
}