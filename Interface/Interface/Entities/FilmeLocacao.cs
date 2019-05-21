using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entidades
{
    class FilmeLocacao
    {
        private DateTime inicio;
        private DateTime fim;
        private Fatura fatura;
        private Filme filme;

        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fim { get => fim; set => fim = value; }
        internal Filme Filme { get => filme; set => filme = value; }
        internal Fatura Fatura { get => fatura; set => fatura = value; }

        public FilmeLocacao(DateTime inicio, DateTime fim, Filme filme)
        {
            Inicio = inicio;
            Fim = fim;
            Filme = filme;
            Fatura = null;
        }
    }
}
