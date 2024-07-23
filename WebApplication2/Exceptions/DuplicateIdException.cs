namespace WebApplication2.Exceptions
{
    public class DuplicateIdException : Exception
    {
        public DuplicateIdException(string message) : base(message) { }
    }
}
