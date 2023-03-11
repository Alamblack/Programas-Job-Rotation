using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distribuidora
{
    internal class Estados
    {
        string sigla; 
        public string siglaGet { get { return sigla; } }
        float faturamentoMensal;
        public float faturamentoMensalGet { get { return faturamentoMensal; }}

        public Estados(string sigla)
        {
            this.sigla = sigla;
            this.faturamentoMensal = 0f;
        }
        public Estados(string sigla, float faturamentoMensal)
        {
            this.sigla = sigla;
            this.faturamentoMensal = faturamentoMensal;
        }

        public override string ToString()
        {
            return "Estado: " + sigla + "\r\nFaturamento Mensal:R$" + faturamentoMensal;
        }
    }
}
