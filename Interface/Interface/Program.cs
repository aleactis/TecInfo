using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Interface.Entidades;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação: ");
            Console.Write("Nome do filme: ");
            string filme = Console.ReadLine();
            Console.Write("Início da locação (dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Fim da locação (dd/MM/yyyy hh:mm): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            FilmeLocacao filmeLocacao = new FilmeLocacao(inicio, fim, new Filme(filme));

            LocadoraServico locadoraServico = new LocadoraServico(hora, dia);

            locadoraServico.ProcessoLocacao(filmeLocacao);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(filmeLocacao.Fatura);
        }
    }
}
