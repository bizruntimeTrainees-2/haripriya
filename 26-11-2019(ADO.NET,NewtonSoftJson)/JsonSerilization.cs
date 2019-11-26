using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

//JSON are used to serializing and transmitting structured data over a network connection
//used to send data between server and web application
//JsonSerializer converts .NET objects into their JSON equivalent text and
//back again by mapping the .NET object property names to the JSON property names



//employee class holding data(i.e object)
//we need to convert .net obj to json format.

class JsonSerilization
{
    static void Main(string[] args)
    {
        //serialization
            Employee[] Employees = new Employee[2]{
            new Employee(){EmployeeId=1,Employeename="ABC"},
            new Employee(){EmployeeId=2,Employeename="XYZ"} };


            company obj = new company() { CompanyName = "BIZ runtime", CompanyAddress = "banglore" ,Employees=Employees };
            DataContractJsonSerializer serObj = new DataContractJsonSerializer(typeof(company));
            //DataContractSerializer-seri,deseri with json obj
            MemoryStream stream = new MemoryStream();
            serObj.WriteObject(stream, obj);
            //ser .net obj to json obj(Company obj to json)
            //company serialize to employee
            string s1 = Encoding.UTF8.GetString(stream.ToArray());
            //getstring-byte,json in the form of string 
            //stream into array(array of byte) 
            File.WriteAllText(@"E:\BASICS OF C#(VISUAL STUDIO)\NewtonSoft\Json.txt",s1);


        //Deserilization
        company DeseriledOb= (company)serObj.ReadObject(new MemoryStream(File.ReadAllBytes(@"E:\BASICS OF C#(VISUAL STUDIO)\NewtonSoft\Json.txt")));

    }
}
    public class company
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public Employee[] Employees { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Employeename { get; set; }
    }


/*
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}



//serilaize
private void JSONSerilaize()
{
    Employee empObj = new Employee();
    empObj.ID = 1;
    empObj.Name = "Manas";
    empObj.Address = "India";

    // Convert employee object to Json string format   
    string jsonData = JsonConvert.SerializeObject(empObj);

    Response.Write(jsonData);
} */