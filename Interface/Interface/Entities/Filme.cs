using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entidades
{
    class Filme
    {
        private string titulo;

        public string Titulo { get => titulo; set => titulo = value; }

        public Filme(string titulo)
        {
            this.Titulo = titulo;
        }
    }
}
