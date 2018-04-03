using System;
using System.Collections.Generic;
using System.Text;

namespace z.Deferred.Exceptions
{
    public class PromiseException : Exception
    {
        public PromiseException() { }

        public PromiseException(string message) : base(message) { }

        public PromiseException(string message, Exception inner) : base(message, inner) { }
    }
}
