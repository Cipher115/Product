namespace WebApplication2.Exceptions
{
    public class DuplicateIdException : Exception
    {
        //Exception for id duplicates 
        public DuplicateIdException(string message) : base(message) { }
    }
}
