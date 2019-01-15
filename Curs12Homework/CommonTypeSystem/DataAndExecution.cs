using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;
using CTS_Models_Interface;

namespace CommonTypeSystem
{
    class DataAndExecution
    {
        public static void Pb02()
        {
            Student originalStudent = new Student("Vartolomei", "Claudiu", "Stefan", 1870725374555);
            Student copyStudent = (Student)originalStudent.Clone();

            Console.WriteLine("\n\n\t PROBLEM NO.2: ");

            Console.WriteLine($"\t    Original: {originalStudent}");
            Console.WriteLine($"\t    Clone: {copyStudent}");

            copyStudent = new Student("Vartolomei", "C.", "Stefan", 1870725374555); ;

            Console.WriteLine($"\n\t    Original: {originalStudent}");
            Console.WriteLine($"\t    Clone (modified): {copyStudent}");
        }

        public static void Pb03()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Nume3", "Prenume1", "Prenume4", 1111111111111));
            listOfStudents.Add(new Student("Nume1", "Prenume2", "Prenume2", 4444444444444));
            listOfStudents.Add(new Student("Nume3", "Prenume2", "Prenume1", 3333333333333));
            listOfStudents.Add(new Student("Nume4", "Prenume4", "Prenume3", 4444444444444));
            listOfStudents.Add(new Student("Nume2", "Prenume3", "Prenume4", 2222222222222));
            listOfStudents.Add(new Student("Nume4", "Prenume1", "Prenume2", 3333333333333));
            listOfStudents.Add(new Student("Nume1", "Prenume3", "Prenume1", 1111111111111));
            listOfStudents.Add(new Student("Nume2", "Prenume4", "Prenume3", 2222222222222));

            Console.WriteLine("\n\n\t PROBLEM NO.3: ");

            Console.WriteLine("\n\t Before sort: ");
            foreach (var stud in listOfStudents)
                Console.WriteLine(stud.ToString());

            listOfStudents.Sort();

            Console.WriteLine("\n\t After sort: ");
            foreach (var stud in listOfStudents)
                Console.WriteLine(stud.ToString());
        }

        public static void Pb04()
        {
            Person person1 = new Person();
            person1.Name = "NUME01";
            //person1.Age = 25;

            Console.WriteLine("\n\n\t PROBLEM NO.4: ");
            Console.WriteLine(person1.ToString());
        }

        public static void Pb05()
        {
            BitArray64 value01 = new BitArray64(125874589);
            BitArray64 value02 = new BitArray64(150000000);

            Console.WriteLine("\n\n\t PROBLEM NO.5: ");
            Console.WriteLine(" ");

            Console.Write("\t Bits for '125874589': ");
            foreach (var bit in value01)
                Console.Write($"{bit}");
            Console.WriteLine(" ");
            Console.WriteLine($"\t Hashcode of {value01.Value} is {value01.GetHashCode()}.");
            Console.WriteLine(" ");
            Console.Write("\t Bits for '150000000': ");
            foreach (var bit in value02)
                Console.Write($"{bit}");
            Console.WriteLine(" ");
            Console.WriteLine($"\t Hashcode of {value02.Value} is {value02.GetHashCode()}.");
        }

        //public static void Pb06()
        //{
        //    Node root = null;
        //    Tree bst = new Tree();
        //    int size = 2000000;
        //    int[] arr = new int[size];

        //    Console.WriteLine($"Generating random array with {size} elements...");

        //    Random rand = new Random();
        //    Stopwatch watch = Stopwatch.StartNew();

        //    for (int i = 0; i < size; i++)
        //        arr[i] = rand.Next(10000);

        //    watch.Stop();

        //    Console.WriteLine($"Done. Took {(double)watch.ElapsedMilliseconds/1000.0} seconds.");
        //    Console.WriteLine(" ");
        //    Console.WriteLine($"Filling the tree with {size} nodes...");

        //    watch = Stopwatch.StartNew();

        //    for (int i = 0; i < size; i++)
        //        root = bst.Insert(root,arr[i]);

        //    watch.Stop();

        //    Console.WriteLine($"Done. Took {(double)watch.ElapsedMilliseconds / 1000.0} seconds.");
        //    Console.WriteLine(" ");
        //    Console.WriteLine($"Traversing all {size} nodes...");

        //    watch = Stopwatch.StartNew();

        //    bst.Traverse(root);

        //    watch.Stop();

        //    Console.WriteLine($"Done. Took {(double)watch.ElapsedMilliseconds / 1000.0} seconds.");
        //    Console.WriteLine(" ");
        //}
    }
}
