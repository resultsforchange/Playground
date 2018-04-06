using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> geneSet = new List<string>() { " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!." };
            string target = "Hello World!";

            var dna = GenerateParent(geneSet, target.Length);
            Console.WriteLine(dna.ToString());
            Console.ReadLine();
        }

        /// <summary>
        /// Generate a random string from the gene set
        /// </summary>
        /// <param name="geneSet">The list to use as our gene set</param>
        /// <param name="numberOfElements">The number of elements that we require</param>
        /// <returns></returns>
        public static IEnumerable<string> GenerateParent(IEnumerable<string> geneSet, int numberOfElements)
        {
            var random = new Random();
            var randomSortTable = geneSet.ToDictionary(x => random.NextDouble(), y => y);
            return randomSortTable.OrderBy(kvp => kvp.Key).Take(numberOfElements).Select(kvp => kvp.Value);
        }
    }
}
