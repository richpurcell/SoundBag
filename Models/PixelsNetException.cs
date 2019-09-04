using System;
using System.Net;

namespace SoundBag
{
    [Serializable]
    public class PexelsNetException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public PexelsNetException()
        {
        }

        public PexelsNetException(HttpStatusCode httpStatusCode, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
