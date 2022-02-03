using System;
namespace Api.DTOs
{
    public class WelcomeMessage
    {
        public WelcomeMessage()
        {
        }

        public string Message { get; set; }
        public string Weather { get; set; }
    }
}