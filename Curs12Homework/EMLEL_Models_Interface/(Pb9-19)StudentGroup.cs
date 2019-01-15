using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLEL_Models_Interface
{
    public class Group
    {
        public int GroupNumber { get; }
        public string DepartmentName { get; }

        public Group(int groupNumber, string deptName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = deptName;
        }
    }
    public class StudentGr
    {
        private string FirstName { get; }
        private string LastName { get; }
        private int FN { get; }
        private int Phone { get; }
        private string Email { get; }
        private List<int> Marks { get; set; }
        private int GroupNo { get; }
        private Group GroupMembership { get; }

        public StudentGr(string firstName, string lastName, int fn, int phone, string email, int groupNo, string deptName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Phone = phone;
            this.Email = email;
            this.GroupNo = groupNo;
            this.Marks = new List<int>();
            this.GroupMembership = new Group(groupNo,deptName);
        }

        public void AddMark(int mark)
        {
            if (mark != 0)
                this.Marks.Add(mark);
        }

        public static List<StudentGr> PopulateStudentsList()
        {
            StudentGr student1 = new StudentGr("Name1", "Name8", 123406, 0232111111, "student1@email.ro", 1,"Mathematics");
            student1.AddMark(8);
            student1.AddMark(10);
            student1.AddMark(9);
            StudentGr student2 = new StudentGr("Name5", "Name3", 123406, 0235222222, "student2@abv.bg", 1, "Science");
            student2.AddMark(7);
            student2.AddMark(8);
            student2.AddMark(9);
            StudentGr student3 = new StudentGr("Name9", "Name2", 123405, 0235333333, "student3@email.ro", 2, "Mathematics");
            student3.AddMark(10);
            student3.AddMark(9);
            StudentGr student4 = new StudentGr("Name3", "Name6", 123405, 0232444444, "student4@abv.bg", 2, "Science");
            student4.AddMark(8);
            student4.AddMark(7);

            List<StudentGr> listOfStudents = new List<StudentGr>();
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);
            listOfStudents.Add(student4);

            return listOfStudents;
        }

        public static void DisplayStudents()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            foreach (var stud in listGroupStudents)
            {
                Console.WriteLine($"\t Student: {stud.FirstName+" "+stud.LastName}, FN: {stud.FN}");
                Console.WriteLine($"\t\t marks: {string.Join(" ", stud.Marks)}, phone: {stud.Phone}, email: {stud.Email}, group: {stud.GroupNo}, department: {stud.GroupMembership.DepartmentName}");
            }
        }

        public static void Pb09()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.9: Using LINQ...");
            var query = from student in listGroupStudents where student.GroupNo == 2 orderby student.FirstName select student;
            foreach (var stud in query)
                Console.WriteLine($"\t First name: {stud.FirstName}, group nr.: {stud.GroupNo}");
        }

        public static void Pb10()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.10: Using Lambda expresions...");
            var query2 = listGroupStudents.Where(group => group.GroupNo == 2).OrderBy(stud => stud.FirstName);
            foreach (var stud in query2)
                Console.WriteLine($"\t First name: {stud.FirstName}, group nr.: {stud.GroupNo}");
        }

        public static void Pb11()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.11: Students with email from 'abv.bg'...");
            var query = listGroupStudents.Where(stud => stud.Email.Contains("abv.bg"));
            foreach (var stud in query)
                Console.WriteLine($"\t First name: {stud.FirstName}, email: {stud.Email}");
        }

        public static void Pb12()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.12: Students with phone from Iasi...");
            var query = from student in listGroupStudents where student.Phone.ToString().Contains("232") select student;
            foreach (var stud in query)
                Console.WriteLine($"\t First name: {stud.FirstName}, phone: {stud.Phone}");
        }

        public static void Pb13()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.13: Students with excellent marks...");
            var query = from student in listGroupStudents where student.Marks.Contains(10) select
                        new { FullName = student.FirstName + " " + student.LastName, Mark = student.Marks };
            foreach (var student in query)
            {
                Console.WriteLine($"\t Student: {student.FullName}, Marks: { string.Join(" ", student.Mark)}");
            }
        }

        public static void Pb14()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.14: Students with only 2 marks...");
            var query = from student in listGroupStudents where student.Marks.Count == 2 select student;

            foreach (var stud in query)
                Console.WriteLine($"\t Student {stud.FirstName+" "+stud.LastName} has only 2 marks.");
        }

        public static void Pb15()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.15: Students enrolled in 2006...");
            var query = from stud in listGroupStudents where stud.FN.ToString().EndsWith("06") select stud;
            foreach (var student in query)
                Console.WriteLine($"\t Student: {student.FirstName+" "+student.LastName}, FN: {student.FN}, marks: {string.Join(",",student.Marks)}");
        }

        public static void Pb16()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.16: Students from 'Mathematics' department...");
            var query = listGroupStudents.Where(stud => stud.GroupMembership.DepartmentName.Contains("Mathematics"));

            foreach (var student in query)
                Console.WriteLine($"\t Student {student.FirstName + " " + student.LastName}, department {student.GroupMembership.DepartmentName}");
        }

        public static void Pb18()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.18: Students grouped by GroupNo. using LINQ...");
            var query = from student in listGroupStudents group student by student.GroupMembership.GroupNumber 
                        into newListOfStudents orderby newListOfStudents.Key select newListOfStudents;

            foreach (var stud in query)
            {
                Console.WriteLine($"\t Group no.: {stud.Key}");
                foreach (var student in stud)
                {
                    Console.WriteLine($"\t Student {student.FirstName+" "+student.LastName}");
                }
            }

        }

        public static void Pb19()
        {
            List<StudentGr> listGroupStudents = PopulateStudentsList();

            Console.WriteLine("\n\t Problem nr.19: Students grouped by GroupNo. using extension methods...");
            var query = listGroupStudents.GroupBy(student => student.GroupMembership.GroupNumber);

            foreach (var stud in query)
            {
                Console.WriteLine($"\t Group no.: {stud.Key}");
                foreach (var student in stud)
                {
                    Console.WriteLine($"\t Student {student.FirstName + " " + student.LastName}");
                }
            }

        }
    }
}
