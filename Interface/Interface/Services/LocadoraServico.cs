using Interface.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    class LocadoraServico
    {
        private double precoPorHora;
        private double precoPorDia;

        public double PrecoPorDia { get => precoPorDia; set => precoPorDia = value; }
        public double PrecoPorHora { get => precoPorHora; set => precoPorHora = value; }

        private BrasilTaxaServico _brasilTaxaServico = new BrasilTaxaServico();
        public LocadoraServico(double precoPorDia, double precoPorHora)
        {
            this.PrecoPorDia  = precoPorDia;
            this.PrecoPorHora = precoPorHora;
        }

        public void ProcessoLocacao(FilmeLocacao filmeLocacao)
        {
            TimeSpan duracao = filmeLocacao.Fim.Subtract(filmeLocacao.Inicio);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _brasilTaxaServico.Taxa(pagamentoBasico);
            filmeLocacao.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
