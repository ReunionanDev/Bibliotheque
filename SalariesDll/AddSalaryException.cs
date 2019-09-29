using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SalariesDll
{
    [Serializable]
    public class SalaryException : ApplicationException, ISerializable
    {
        private string _idMessage = string.Empty;

        public string IdMessage
        {
            get
            {
                return _idMessage;
            }
            set
            {
                _idMessage = value;
            }
        }
        public SalaryException()
            : base()
        {
        }

        public SalaryException(string IdMessage, string message)
            : base(message)
        {
            _idMessage = IdMessage;
        }

        public SalaryException(string IdMessage, string message, Exception inner)
            : base(message, inner)
        {
            _idMessage = IdMessage;
        }

        protected SalaryException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
