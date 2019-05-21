using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interface.Entidades
{
    class Fatura
    {
        private double taxa;
        private double pagamentoBasico;
        private double pagamentoTotal;
        public double Taxa { get => taxa; set => taxa = value; }
        public double PagamentoBasico { get => pagamentoBasico; set => pagamentoBasico = value; }
        public double PagamentoTotal { get => PagamentoBasico + taxa; }

        public Fatura(double taxa, double pagamentoBasico)
        {
            this.Taxa = taxa;
            this.PagamentoBasico = pagamentoBasico;
        }

        public override string ToString()
        {
            return "Pagamento básico"
                + pagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: " + taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total: " + pagamentoTotal.ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
