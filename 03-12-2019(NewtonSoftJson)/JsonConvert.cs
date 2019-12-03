using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections;

namespace Json
{

    class jsonconvert
    {
        public static void Main(string[] args)
        {
            //object intializer to initialize its property
            Student student = new Student()
            {//this obj into Json and store in file
                id = 1,
                Name = "ABC",
                Degree = "B.tech",
                Hobbies = new List<string>()
                {
                 "Reading",
                 "playing games"
                 }//Construction of obj

            };
            //St to json
            //serializeObject-obj into json ,returns string,string holds json format
            string strResultJson = JsonConvert.SerializeObject(student);
            // Console.WriteLine(strResultJson);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("Stored!");



            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"student.json");
            //var resultStudent= JsonConvert.DeserializeObject<Student>(strResultJson);
            //Console.WriteLine(resultStudent.ToString());
            //Console.ReadLine();
            //Json-key,value,Dicto
            //dese,json to dic 
            var dic = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach (DictionaryEntry entry in dic)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            Console.ReadLine();
        }
    }
}