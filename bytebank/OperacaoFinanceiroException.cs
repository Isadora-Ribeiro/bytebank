using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_execption
{
    public class OperacaoFinanceiroException : Exception
    {

        public OperacaoFinanceiroException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiroException(string mensagem, Exception exececaoInterna) : base (mensagem, exececaoInterna)
        { 
            
        }
    }
}
