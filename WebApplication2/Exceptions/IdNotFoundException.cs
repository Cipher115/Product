namespace WebApplication2.Exceptions
{
    public class IdNotFoundException : Exception
    {
        //If id is not found this message will pop up
        public IdNotFoundException(string message): base(message) { }
    }
}
