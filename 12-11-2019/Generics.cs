using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Generics
    {
        public static void Main()
        {
            GenericClass<int> intGenericClass = new GenericClass<int>(10);
           
            int val = intGenericClass.genericMethod(2);
            Console.ReadLine();

        }
    }

    public class GenericClass<T>
    {
        private T genericMemberVariable;

        public GenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }
