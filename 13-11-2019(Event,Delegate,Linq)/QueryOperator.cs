using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

/*
public class Program
{
    public static void Main()
    {
               IList<student> studentList = new List<student>() {
                new student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

        var orderByResult = from s in studentList
                            orderby s.StudentName
                            select s;

        var orderByDescendingResult = from s in studentList 
                                      orderby s.StudentName descending
                                      select s;

        Console.WriteLine("Ascending Order:");

        foreach (var std in orderByResult)
            Console.WriteLine(std.StudentName);

        Console.WriteLine("Descending Order:");

        foreach (var std in orderByDescendingResult)
            Console.WriteLine(std.StudentName);
        Console.ReadLine();

    }

}

public class student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}*/
/*
Lambda Expression:	
public class Program
{
	public static void Main()
	{
		        IList<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
			};
		
		var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
		var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);
		Console.WriteLine("Ascending Order:");

		foreach (var std in studentsInAscOrder)
        	Console.WriteLine(std.StudentName);
		
		Console.WriteLine("Descending Order:");
		
		foreach (var std in studentsInDescOrder)
        	Console.WriteLine(std.StudentName);
	}
}

public class Student{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
	
}*/

public class Program
{
	public static void Main()
	{
		IList<student> studentList = new List<student>() { 
				new student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
			};
		
		var multiSortingResult = from s in studentList
								orderby s.StudentName, s.Age 
								select s;
		
		
		foreach (var std in multiSortingResult)
			Console.WriteLine("Name: {0}, Age {1}",std.StudentName, std.Age);
        Console.ReadLine();

	}
}

class student{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
	
}
