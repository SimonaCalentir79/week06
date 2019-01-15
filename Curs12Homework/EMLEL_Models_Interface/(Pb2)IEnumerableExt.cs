using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLEL_Models_Interface
{
    public static class MethodsIEnum
    {
        public static T Sum<T>(this IEnumerable<T> enumerabile)
        {
            dynamic sum = 0;

            foreach (var val in enumerabile)
            {
                sum = sum + val;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumerabile)
        {
            dynamic product = 1;

            foreach (var val in enumerabile)
            {
                product = product * val;
            }
            return product;
        }

        public static T Average<T>(this IEnumerable<T> enumerabile)
        {
            dynamic sum = 0;
            dynamic counter = 0;
            dynamic average = 0;

            foreach (var val in enumerabile)
            {
                sum = sum + val;
                counter++;
            }
            average = sum / counter;
            return average;
        }

        public static T Min<T>(this IEnumerable<T> enumerabile) where T:IComparable<T>
        {
            T min = enumerabile.First<T>();
            foreach (var val in enumerabile)
            {
                if (val.CompareTo(min) < 0)
                    min = val;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumerabile) where T:IComparable<T>
        {
            T max = enumerabile.Last<T>();
            foreach (var val in enumerabile)
            {
                if (val.CompareTo(max) > 0)
                    max = val;
            }
            return max;
        }

        public static void Pb02()
        {
            decimal[] numere = new decimal[] { 40, 30, 50, 20, 10 };

            Console.WriteLine($"\n\t Numbers are: ");
            foreach(var val in numere)
                Console.Write($"\t {val} ");

            Console.WriteLine($"\n\n\t Sum: {numere.Sum()}");
            Console.WriteLine($"\n\t Product: {numere.Product()}");
            Console.WriteLine($"\n\t Average: {numere.Average()}");
            Console.WriteLine($"\n\t Minimum: {numere.Min()}");
            Console.WriteLine($"\n\t Maximum: {numere.Max()}");
        }
    }
}
