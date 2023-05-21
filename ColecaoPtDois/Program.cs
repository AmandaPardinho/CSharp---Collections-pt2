using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoPtDois
{
    public class Program
    {
        static void Main(string[] args)
        {
            //criando um dicionário de alunos
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n");

            //removendo um aluno e adicionando outro
            alunos.Remove("AL");
            alunos.Add("MO", new Aluno("Marcelo", 12345));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("\n");

            /* os elementos de um dicionário não possuem uma ordem definida
             * as chaves são espalhadas pelo hash
             */
            /*SortedList:
             * implementa um IDictionary
             */
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
