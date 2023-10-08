using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab4.Exeptions
{
    [Serializable]
    public class InvalidSettlementException : System.Exception
    {
        public InvalidSettlementException()
        {
        }

        public InvalidSettlementException(string message) : base(message)
        {
        }

        public InvalidSettlementException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidSettlementException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
