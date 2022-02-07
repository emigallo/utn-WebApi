using System;
namespace Api.Exceptions
{
    public class UserNonExistException : UserInvalidException
    {
        public UserNonExistException()
        {
            base.MessageToShow = "El usuario no existe en el sistema.";
        }
    }
}