using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaColecao3
{
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

            //retornar o primeiro trimestre
            var consulta = meses.Take(3);
            foreach (var trimestre in consulta) 
            {
                Console.WriteLine(trimestre);
            }
            Console.WriteLine();

            //retornar todos os meses que vem após o primeiro trimestre
            var consulta2 = meses.Skip(3);
            foreach(var mesesSeguintes in consulta2)
            {
                Console.WriteLine(mesesSeguintes);
            }
            Console.WriteLine();
           
            //retornar os meses do terceiro trimestre
            var consulta3 = meses.Skip(6).Take(3);
            foreach (var trimestre3 in consulta3)
            {
                Console.WriteLine(trimestre3);
            }
            Console.WriteLine();

            //retornar os meses até que o nome do mês comece com a letra 'S'
            var consulta4 = meses.TakeWhile(mes => !mes.NomeMes.StartsWith('S'));
            foreach (var nomeMeses in consulta4)
            {
                Console.WriteLine(nomeMeses);
            }
            Console.WriteLine();

            //pular os meses até que o nome do mês comece com a letra 'S'
            var consulta5 = meses.SkipWhile(mes => !mes.NomeMes.StartsWith('S'));
            foreach(var nomeMeses in consulta5)
            {
                Console.WriteLine(nomeMeses);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
