
using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int Age { get; set; }
}

public class QueryOperators
{

    public static void Main(string[] args)
    {
        IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 25 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
        Console.WriteLine("OrderBy, ThenBy - Method Syntax\n");
        var result = studentList.OrderByDescending(s => s.StudentName).ThenByDescending(s => s.StudentID);

        foreach (Student std in result)
        {
            Console.WriteLine(std.StudentID + " - " + std.StudentName + " - " + std.Age);
        }
        Console.WriteLine();
        Console.WriteLine("\n orderby - Query Syntax \n");
        var objList = from s in studentList orderby s.StudentName descending, s.StudentID descending select new { Id = s.StudentID, s.StudentName, s.Age };

        foreach (Object std in objList)
        {
            Console.WriteLine(std);
        }
        Console.ReadLine();

    }
}
/*
 * OrderBy, ThenBy - Method Syntax

2 - Steve - 15
5 - Ron - 15
4 - Ram - 25
1 - John - 18
3 - Bill - 25


 orderby - Query Syntax

{ Id = 2, StudentName = Steve, Age = 15 }
{ Id = 5, StudentName = Ron, Age = 15 }
{ Id = 4, StudentName = Ram, Age = 25 }
{ Id = 1, StudentName = John, Age = 18 }
{ Id = 3, StudentName = Bill, Age = 25 }


 GroupBy - query Syntax

18
1 - John - 18
15
2 - Steve - 15
5 - Ron - 15
25
3 - Bill - 25
4 - Ram - 25


 GroupBy & OrderBy - Method Syntax

{ ID = 1, StudentName = John, Age = 18 }
{ ID = 4, StudentName = Ram, Age = 25 }
{ ID = 5, StudentName = Ron, Age = 15 }


 ToLookUp - Method Syntax
 -------------------------
18
1 - John - 18
15
2 - Steve - 15
5 - Ron - 15
25
3 - Bill - 25
4 - Ram - 25
*/
