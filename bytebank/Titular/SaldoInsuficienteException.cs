using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_execption.Titular
{
    public class SaldoInsuficienteException : OperacaoFinanceiroException
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
