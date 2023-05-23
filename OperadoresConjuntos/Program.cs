using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConjuntos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril"};

            //concatenar duas sequências
            var consulta1 = seq1.Concat(seq2);
            foreach (var item in consulta1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //unir duas sequências (não há repetição do elemento em comum)
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //unir duas sequências com comparador
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //intersecção de duas sequências
            var consulta4 = seq1.Intersect(seq2);
            foreach(var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //elementos da sequência 1 que não estão na sequência 2
            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

