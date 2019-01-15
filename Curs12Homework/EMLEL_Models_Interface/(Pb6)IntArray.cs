using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLEL_Models_Interface
{
    public class IntArray
    {
        public static int[] PopulareArray()
        {
            int[] arrOfIntergers = new int[50];
            Random randomNumber = new Random();

            for (int i = 0; i < arrOfIntergers.Length; i++)
            {
                arrOfIntergers[i] = randomNumber.Next(2000);
            }

            foreach (var number in arrOfIntergers)
                Console.Write($" {number} ");

            return arrOfIntergers;
        }

        public static void usingLinq()
        {
            Console.WriteLine("\n Numbers from array are: ");
            int[] newArr = PopulareArray();

            var queryFor3 = from nr in newArr where nr % 3 == 0 select nr;
            var queryFor7 = from nr in queryFor3 where nr % 7 == 0 select nr;

            Console.WriteLine("\n\n Divisible by 3 & 7 are: ");
            foreach (var div7 in queryFor7)
                Console.Write($" {div7} ");
        }

        public static void usingLambdaExpr()
        {
            Console.WriteLine("\n Numbers from array are: ");
            int[] newArr = PopulareArray();

            IEnumerable<int> query = newArr.Where(nr => (nr%3==0) && (nr%7==0));
            Console.WriteLine("\n\n Divisible by 3 & 7 are: ");
            foreach (var div in query)
                Console.Write($" {div} ");
        }

        public static void Pb06()
        {
            Console.WriteLine("\n Using LINQ...");
            usingLinq();

            Console.WriteLine("\n\n\n Using Lambda expresions...");
            usingLambdaExpr();
        }
    }
}
