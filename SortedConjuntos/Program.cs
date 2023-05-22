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

            //declarando outro conjunto
            ISet<string> outroConjunto = new HashSet<string>();

            //o conjunto é subconjunto do conjunto alunos?
            alunos.IsSubsetOf(outroConjunto);

            //o conjunto é superconjunto do conjunto alunos? 
            alunos.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmos elementos? 
            alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão neste conjunto
            alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos 
            alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto
            alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos
            alunos.UnionWith(outroConjunto);

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
