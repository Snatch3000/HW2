using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class NoCategoryException : ApplicationException
    {
        public NoCategoryException() { }

        public NoCategoryException(string message) : base(message) { }

        public NoCategoryException(string message, Exception inner) : base(message, inner) { }

        protected NoCategoryException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
