using System;

namespace AspNetCore.Mvc.Extensions.Validation.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message):base(message)
        {

        }
    }
}
