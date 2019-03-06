namespace SalesWebMVC.Services.Exceptions
{
    using System;

    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
