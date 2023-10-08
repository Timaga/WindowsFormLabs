using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4.Exeptions
{
    [Serializable]
    public class InvalidAspiranteException : System.Exception
    {
        public InvalidAspiranteException()
        {
        }

        public InvalidAspiranteException(string message) : base(message)
        {
        }

        public InvalidAspiranteException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidAspiranteException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
