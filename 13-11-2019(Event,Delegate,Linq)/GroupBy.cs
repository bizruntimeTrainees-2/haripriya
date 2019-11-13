using System;
using System.Linq;
using System.Collections.Generic;

 class GroupBy
{
    public static void Main()
    {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

        var groupedResult = from s in studentList
                            group s by s.Age;
        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key);  

            foreach (Student s in ageGroup) 
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }
        Console.ReadLine();

    }

}
 