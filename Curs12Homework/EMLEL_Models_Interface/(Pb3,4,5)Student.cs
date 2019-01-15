using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLEL_Models_Interface
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public static List<Student> PopulareStudenti()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Name1", "Name2", 19));
            listOfStudents.Add(new Student("Name3", "Name1", 22));
            listOfStudents.Add(new Student("Name2", "Name3", 25));
            listOfStudents.Add(new Student("Name1", "Name4", 18));
            listOfStudents.Add(new Student("Name3", "Name6", 21));
            listOfStudents.Add(new Student("Name2", "Name5", 26));

            Console.WriteLine("\n\t INITIAL list of students");
            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"\t First name: {student.FirstName}, Last name: {student.LastName}, Age: {student.Age}");
            }

            return listOfStudents;
        }

        public static void Pb03()
        {
            Console.WriteLine("\n\t PROBLEM NO. 3");

            List<Student> listOfStud = PopulareStudenti();
            var sortedFName = from student in listOfStud where student.FirstName.CompareTo(student.LastName) == -1 select (student.FirstName + " " + student.LastName);
            var newListOfStudents = listOfStud.Where(stud => stud.FirstName.CompareTo(stud.LastName) < 0);

            Console.WriteLine("\n\t SORTED (by First name) list of students");
            foreach (var name in newListOfStudents)
                Console.WriteLine($"\t First name: {name.FirstName}, Last name: {name.LastName}");
        }

        public static void Pb04()
        {
            Console.WriteLine("\n\t PROBLEM NO. 4");

            List<Student> listOfStud = PopulareStudenti();
            var intervalStudents = listOfStud.Where(stud => (stud.Age.CompareTo(18)==1) && (stud.Age.CompareTo(24)==-1));

            Console.WriteLine("\n\t Students with age between 18 and 24");
            foreach (var student in intervalStudents)
                Console.WriteLine($"\t First name: {student.FirstName}, Last name: {student.LastName}, Age: {student.Age}");
        }

        public static void Pb05()
        {
            Console.WriteLine("\n\t PROBLEM NO. 5");

            List<Student> listOfStudents = PopulareStudenti();
            IEnumerable<Student> query = listOfStudents.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            Console.WriteLine("\n\t SORTED list of students (OrderBy(), ThenBy())");
            foreach (var stud in query)
                Console.WriteLine($"\t First name: {stud.FirstName}, Last name: {stud.LastName}, Age: {stud.Age}");

            var sortedList = from student in listOfStudents orderby student.FirstName, student.LastName select student;
            Console.WriteLine("\n\t SORTED list of students (using LINQ query)");
            foreach (var newStud in sortedList)
                Console.WriteLine($"\t First name: {newStud.FirstName}, Last name: {newStud.LastName}, Age: {newStud.Age}");
        }
    }
}
