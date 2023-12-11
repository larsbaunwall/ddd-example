using System;

namespace Messaging.Contracts
{
    public class Response(bool isSuccessful, Exception exception = null, string message = null)
    {
        public bool IsSuccessful { get; private set; } = isSuccessful;
        public Exception Exception { get; private set; } = exception;
        public string Message { get; private set; } = message;

        public static Response Unsuccessful(string message = null, Exception exception = null)
        {
            return new Response(false, exception, message);
        }

        public static Response Success()
        {
            return new Response(true);
        }
    }
}