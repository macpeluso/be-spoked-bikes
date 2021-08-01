using System;
using System.Net;

namespace BeSpokedBikes.Domain.Exceptions
{
    public class RestException : Exception
    {
        public HttpStatusCode Code { get; set; }
        public object Errors { get; set; }
        public RestException()
        { }
        public RestException(HttpStatusCode code, object errors = null)
        {
            this.Code = code;
            this.Errors = errors;
        }
        public RestException(string message)
            : base(message)
        {
            this.Errors = message;
            this.Code = HttpStatusCode.BadRequest;
        }

        public RestException(object errors)
        {
            this.Errors = errors;
            this.Code = HttpStatusCode.BadRequest;
        }
        public RestException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}