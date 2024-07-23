namespace WebApplication2.Exceptions
{
    public class NegativeNumberException : Exception
    {
        //Price and id negative numbers are invalid
        public NegativeNumberException(string message): base(message){ }
    }
}
