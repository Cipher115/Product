﻿namespace WebApplication2.Exceptions
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException(string message): base(message) { }
    }
}
