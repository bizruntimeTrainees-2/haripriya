using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class generics<T>//generic type parameter
    {
        private T data;
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }

    class Generic
    {
       public static void Main(string[] args)
        {
            generics<string> name = new generics<string>();
            name.value = "runtime";
            generics<float> number = new generics<float>();
            number.value = 5.0F;
            Console.WriteLine(name.value);
            Console.WriteLine(number.value);
            Console.ReadLine();
        }
    }