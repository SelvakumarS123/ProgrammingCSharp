using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Generics
    {

        public Generics() { }
    }
    public class Box<T>
    {
        private T content;

        //public T Content { get; set; }

        public Box(T content) 
        { 
            this.content = content;
        }

        //public string Log()
        //{
        //    return $"Box contains: {Content}";
        //}

        public void UpdateContent(T newContent)
        {
            content = newContent;
            Console.WriteLine($"Updated Content: {content}");
        }

        public T GetContent() //return type
        {
            return content;
        }
    }

    public class MultipleGenTypes<Tfirst, Tsecond>
    {
        

        public Tfirst First { get; set; }
        public Tsecond Sec { get; set; }

        public MultipleGenTypes(Tfirst first, Tsecond sec)
        {
            First = first;
            Sec = sec;
        }

        public void Display()
        {
            Console.WriteLine($"first: {First}\nsecond: {Sec}");
        }
    }

    public class GenMethodsInsideNonGenClass
    {
        public void Log<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
