using System.Collections.Generic;

namespace Json
{
    class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        //list of strings
        public List<string> Hobbies { get; set; }


        public override string ToString()
        {
            return string.Format("Student Info:\n\t id: {0},\n\t Name: {1},\n\t Degree: {2}," + "\n\t Hobbies: {3}", id, Name,Degree,string.Join(",",Hobbies.ToArray()));
        }
    }

}
