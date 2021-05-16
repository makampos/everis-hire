using System;

namespace EverisHire.HireManagement.Application.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message): base(message)
        {
            
        }
        
    }
}