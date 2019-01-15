using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CTS_Models_Interface
{
    public class Student:ICloneable, IComparable<Student>
    {
        public enum Speciality { Spec1, Spec2, Spec3, Spec4, Spec5 }
        public enum University { Univ1, Univ2, Univ3, Univ4, Univ5 }
        public enum Faculty { Faculty1, Faculty2, Faculty3, Faculty4, Faculty5 }

        private string FirstName { get; }
        private string MiddleName { get; }
        private string LastName { get;  }
        private double CNP { get; }
        private string Address { get; }
        private string MobilePhone { get; }
        private string Email { get; }
        private string Course { get; }
        private Speciality speciality;
        private University university;
        private Faculty faculty;


        public Student(string lastName, string middleName, string firstName, double CNP)
        {
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.FirstName = firstName;
            this.CNP = CNP;
        }

        public override bool Equals(object obiect)
        {
            Student student = obiect as Student;//if the cast is invalid, the result will be null
            if (student == null)
                return false;
            if (!Object.Equals(this.CNP, student.CNP))//compare the reference type member fields
                return false;
            if (!Object.Equals(this.LastName, student.LastName))
                return false;
            if (this.CNP != student.CNP)//compare the value type member fields
                return false;
            if (this.LastName != student.LastName)
                return false;
            return true;
        }

        public static bool operator == (Student student1, Student student2)
        {
            return Student.Equals(student1,student2);
        }

        public static bool operator != (Student student1, Student student2)
        {
            return !Student.Equals(student1,student2);
        }

        public override int GetHashCode()//HashCode = sort of fingerprint
        {
            return CNP.GetHashCode() ^ LastName.GetHashCode();
        }

        public override string ToString()
        {
            return "\t Student: " + LastName + " " + MiddleName + " " + FirstName + ", CNP: " + CNP;
        }

        public object Clone()//inteleg ca e o chestie f complicat de obtinut pe partea de DeepCloning...
        {
            return new Student(this.LastName, this.MiddleName, this.FirstName, this.CNP);
        }

        public int CompareTo(Student otherStudent)
        {
            if (String.Compare(this.LastName, otherStudent.LastName) == 0
                && String.Compare(this.MiddleName, otherStudent.MiddleName) == 0
                && String.Compare(this.FirstName, otherStudent.FirstName) == 0
                && this.CNP == otherStudent.CNP)
                return 0;
            else if (String.Compare(this.LastName, otherStudent.LastName) > 0)
                return 1;
            else if (String.Compare(this.LastName, otherStudent.LastName) == 0
                && String.Compare(this.MiddleName, otherStudent.MiddleName) > 0)
                return 1;
            else if (String.Compare(this.LastName, otherStudent.LastName) == 0
                && String.Compare(this.MiddleName, otherStudent.MiddleName) == 0
                && String.Compare(this.FirstName, otherStudent.FirstName) > 0)
                return 1;
            else if (String.Compare(this.LastName, otherStudent.LastName) == 0
                && String.Compare(this.MiddleName, otherStudent.MiddleName) == 0
                && String.Compare(this.FirstName, otherStudent.FirstName) == 0
                && this.CNP > otherStudent.CNP)
                return 1;
            else
                return -1;
        }
    }
}
