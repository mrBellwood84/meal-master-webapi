namespace Persistence.Exceptions
{
    /// <summary>
    /// Exception for db methods not used by application. 
    /// </summary>
    public class NoDatabaseActionException : Exception
    {
        public NoDatabaseActionException() { }
        public NoDatabaseActionException(string message) : base(message) { }
        public NoDatabaseActionException(string message, Exception innerException) : base(message, innerException) { }
    }
}
