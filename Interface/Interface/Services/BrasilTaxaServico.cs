using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    class BrasilTaxaServico
    {
        public double Taxa(double montante)
        {
            if (montante <= 100.0)
            {
                return montante * 0.2;
            }
            else
            {
                return montante * 0.15;
            }
        }
    }
}
