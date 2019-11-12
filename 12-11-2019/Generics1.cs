using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Generics1
    {
    public static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            Console.WriteLine(intList.Count);
            IList<Student> studentList = new List<Student>() {
            new Student(){ StudentID=1, StudentName="Bill"},
            new Student(){ StudentID=2, StudentName="Steve"},
            new Student(){ StudentID=3, StudentName="Ram"},
            new Student(){ StudentID=1, StudentName="Moin"}
            };
            Console.WriteLine(studentList.Count);
        Console.ReadLine();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

    }