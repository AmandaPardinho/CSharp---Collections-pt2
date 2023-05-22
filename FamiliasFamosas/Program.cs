using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliasFamosas
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* família 1: Família Flintstones;
             * família 2: Família Simpsons;
             * família 3: Família Dona Florinda;
             */

            /*jagged array => array denteado ou array serrilhado ou array de arrays
             * necessidade de ser inicializado pelo índice;
             * declara o número de elementos do array (vertical)
             * não define a outra dimensão do array => vai variar (horizontal)
             */
            string[][] familias = new string[3][];

            //{
            //    "Fred", "Wilma", "Pedrita",
            //    "Homer", "Marge", "Lisa", "Bart", "Maggie",
            //    "Florinda", "Kiko"
            //};

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(", ", familia));
            }
        }
    }
}