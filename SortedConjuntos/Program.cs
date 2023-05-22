using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedConjuntos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criando um conjunto ordenado de alunos
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            //Adicionando novos alunos
            alunos.Add("Rafael Rollo");
            alunos.Add("Fábio Gushiken");
            alunos.Add("Fábio Gushiken");
            alunos.Add("FÁBIO GUSHIKEN");

            //Imprimindo a lista
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadKey();
        }
    }

    public class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
