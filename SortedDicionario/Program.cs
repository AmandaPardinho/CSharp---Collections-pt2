using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDicionario
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criação de um dicionário
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
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

            //SortedList ordenando os alunos
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

            /* SortedDictionary:
             * implementa uma árvore binária e, a partir dela, define a ordem dos elementos em relação aos nós
             * a árvore é balanceada, ou seja, conforme o número de elementos aumenta, há um rearranjo dos nós para que ela fique mais larga que profunda
             * é uma estrutura mais ágil que a SortedList devido a essa forma de árvore
             * o rearranjo permite trafegar por menos elementos para chegar no elemento desejado
             * os elementos à esquerda => possuem valor menor que o do nó
             * os elementos à direita => possuem valor maior que o do nó
             */

            //Criação de um SortedDictionary
            IDictionary<string, Aluno> sortedDict = new SortedDictionary<string, Aluno>();
            sortedDict.Add("VT", new Aluno("Vanessa", 34672));
            sortedDict.Add("AL", new Aluno("Ana", 5617));
            sortedDict.Add("RN", new Aluno("Rafael", 17645));
            sortedDict.Add("WM", new Aluno("Wanderson", 11287));

            foreach(var item in sortedDict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
