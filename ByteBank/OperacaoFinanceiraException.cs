using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string message) : base(message)
        {
        }
        public OperacaoFinanceiraException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
