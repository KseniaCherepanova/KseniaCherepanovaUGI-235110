using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "саксофон";
            Console.WriteLine($"Из слова \"{s}\" получили:");

            var word1 = s
                .Substring(7, 1)  
                + s.Substring(6, 1)
                + s.Remove(5, 3)    
                .Remove(0, 3)    
                + s.Substring(2, 1); 
              

            Console.WriteLine(word1);


            var word2 = s
                .Substring(5, 1)
                + s.Substring(1, 1)
                + s.Substring(0, 1)
                + s.Remove(0, 5)
                .Substring(1, 2);


            Console.WriteLine(word2);







            Console.ReadKey();
        }

       
    }
}
