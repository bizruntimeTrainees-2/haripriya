using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class Employee
{
    enum Design { Webdeveloper, Networkengineer, Developer, Tester, SoftwareEngineer, Hacker };

    enum Dept { Account, Finance, HR, Marketing, Analysis, service };
    public static void Main()
    {
        PrintEmployee();
        Console.WriteLine("All employee details displayed");
    }
    /*public string employeeName;s
    public int employeeId;
    public string companyName;
    public int companyId;
    public string designation;
    public string department;*/

    public static void PrintEmployee()
    {

        var list = new List<Employee>();
        Employee emp = new Employee();

        string[] empname = { "Chandu","Deepu","Deepak","Deepika",
"Deepthi","Fathima","Gouri","Ganesh","Hari","Hareesh","Honey","Happy","Jyothi","John" };
        Int32[] compid = { 1, 2, 3, 4, 5, 6 };

        string[] compname = { "BIZRUNTIME", "HP", "WIPRO", "TCS", "ACER", "MICRO" };

        StringBuilder csvcontent = new StringBuilder();

        csvcontent.AppendLine("empid,empname, design,dept,compid,compname");
        string csvPath = @"C:\Users\DELL\Desktop\TASK2\TASK2.csv";
        int empid = 504;
        for (int j = 1; j <= 5; j++)
        {
            for (int i = 1; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    csvcontent.AppendLine(++empid + "," + empname[0] + "," + Design.Webdeveloper + "," + Dept.Account + "," + compid[0] + "," + compname[0]);
                }
                else if (i % 3 == 0)
                {
                    csvcontent.AppendLine(++empid + "," + empname[1] + "," + Design.Networkengineer + "," + Dept.Finance + "," + compid[1] + "," + compname[1]);
                }
                else if (i % 4 == 0)
                {
                    csvcontent.AppendLine(++empid + "," + empname[2] + "," + Design.Developer + "," + Dept.HR + "," + compid[2] + "," + compname[2]);
                }
                else if (i % 5 == 0)
                {
                    csvcontent.AppendLine(++empid + "," + empname[3] + "," + Design.Tester + "," + Dept.Marketing + "," + compid[3] + "," + compname[3]);
                }
                else if (i % 6 == 0)
                {
                    csvcontent.AppendLine(++empid + "," + empname[4] + "," + Design.SoftwareEngineer + "," + Dept.Analysis + "," + compid[4] + "," + compname[4]);
                }
                else
                {
                    csvcontent.AppendLine(++empid + "," + empname[5] + "," + Design.Hacker + "," + Dept.service + "," + compid[5] + "," + compname[5]);
                }
            }

        }
        File.AppendAllText(csvPath, csvcontent.ToString());
    }
}

//Console.WriteLine("empname:{0}", employeeName, "empid:{0}", employeeId, "compname:{0}", companyName, "compid:{0}", companyId, "design:{0}", designation, "dept:{0}", department);