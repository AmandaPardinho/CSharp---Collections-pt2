using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaColecao2
{
    //Solução mais legível do problema proposto 

    public class Mes
    {
        public Mes(string nomeMes, int dias)
        {
            NomeMes = nomeMes;
            Dias = dias;
        }

        public string NomeMes { get; private set; }
        public int Dias { get; private set; }

        public override string ToString()
        {
            return $"{NomeMes} - {Dias}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Obter os nomes dos meses do ano que têm 31 dias, em maiúsculo e em ordem alfabética;

            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            /*LINQ => Consulta Integrada à Linguagem
             * fornece ferramentas para usar com coleções;
             * poderoso;
             * métodos de extensão;
             * baseado em consultas SQL;
             */

            //montagem da consulta
            IEnumerable<string> consulta = meses.Where(mes => mes.Dias == 31).OrderBy(mes => mes.NomeMes).Select(mes => mes.NomeMes.ToUpper());

            //impressão da consulta
            foreach (var itemMes in consulta) 
            {
                Console.WriteLine(itemMes);
            }

            Console.ReadKey();
        }
    }
}
