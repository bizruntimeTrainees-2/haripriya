using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string AcadmicYear { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class StudentsDatabase : List<Student>
    {
        public StudentsDatabase()
        {
            Add(new Student()
            {
                StudentId = 1,
                StudentName = "MS",
                AcadmicYear = "First",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });

            Add(new Student()
            {
                StudentId = 2,
                StudentName = "LS",
                AcadmicYear = "Second",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" }
            }
            });
            Add(new Student()
            {
                StudentId = 3,
                StudentName = "TS",
                AcadmicYear = "Third",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });
            Add(new Student()
            {
                StudentId = 4,
                StudentName = "VB",
                AcadmicYear = "First",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });

            Add(new Student()
            {
                StudentId = 5,
                StudentName = "PB",
                AcadmicYear = "Second",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" },
                 new Course() {CourseId=106,CourseName="KnockoutJS" }
            }
            });
            Add(new Student()
            {
                StudentId = 6,
                StudentName = "AB",
                AcadmicYear = "Third",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
    }

    public class EmployeesDatabase : List<Employee>
    {
        public EmployeesDatabase()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "A", DeptName = "IT" });
            Add(new Employee() { EmpNo = 1, EmpName = "B", DeptName = "Systems" });
            Add(new Employee() { EmpNo = 1, EmpName = "C", DeptName = "IT" });
            Add(new Employee() { EmpNo = 1, EmpName = "D", DeptName = "Systems" });
            Add(new Employee() { EmpNo = 1, EmpName = "E", DeptName = "IT" });
            Add(new Employee() { EmpNo = 1, EmpName = "F", DeptName = "Systems" });

        }
    }
}
