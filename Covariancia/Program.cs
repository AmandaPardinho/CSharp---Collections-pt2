using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia
{
    public class Program
    {
        static void Main(string[] args)
        {
            //converter uma string para um object (conversão implícita pois string herda de object)
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();

            /*converter List<string> para List<object>
             * interface IList não permite a conversão de IList<string> em IList<object>;
            */
            IList<string> listaMeses = new List<string> 
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            /*converter um array de string (string[]) em um array de object(object[])
             * é possível a conversão implícita devido à covariância
             * a classe Array herda de object e as classes string[] e object[] herdam de Array
             * covariância: ambas as classes herdam uma outra classe em comum
             * covariância do array deve ser evitada sempre
             */
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses;
            Console.WriteLine(arrayObj);
            foreach (var item in arrayObj) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MÊS";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //o código abaixo dá erro => ao associar o arrayObj a um array de string, ele passa a ser um array de string também
            ///arrayObj[0] = 12345;
            ///Console.WriteLine(arrayObj[0]);
            ///Console.WriteLine();

            /*converter uma LIst<string> em um IEnumerable<object>
             * é possível converter implicitamente (covariância)
             * conversão segura => não possui indexador
             */
            IEnumerable<object> enumObj = listaMeses;
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}