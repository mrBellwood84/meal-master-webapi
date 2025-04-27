namespace Application.Exceptions
{
    public class NoServiceException : Exception
    {
        public NoServiceException() { }

        public NoServiceException(string? message) : base(message) { }

        public NoServiceException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
