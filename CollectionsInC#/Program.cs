using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;
using System.Collections;
using System;

namespace CollectionsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nos = [1,2,9,5,8,3,10,56,78,34,67,0];
            Predicate<int> isGreaterThanTen = x => x >  10;//all the elements >= 10

            //Console.WriteLine(isGreaterThanTen(15));  // Outputs: True
            //Console.WriteLine(isGreaterThanTen(5));

            //Any Method
            if (nos.Any(x => x > 50))
            {
                Console.WriteLine("There are nos >50");
            }
            else
            {
                Console.WriteLine("No nos>50");
            }

            List<int> higherThanTen = nos.FindAll(isGreaterThanTen); 
            foreach (int n in higherThanTen)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            //int x = nos.Find(x=>x==78);
            //Console.WriteLine(x);

            List<string> colors = ["red", "blue", "red", "green", "red"];
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            bool isRemoved = colors.Remove("red");
            while (isRemoved)//remove all the reds
            {
                isRemoved=colors.Remove("red");
            }

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }


            //List<Product> products = new List<Product>(); //creating a list of our complex data type(class)
            //products.Add(new Product { Name = "berries", Price = "400" });

            List<Product> products = new List<Product>
            {
                new Product {Name="flower", Price= 10 },
                new Product { Name = "cerries", Price = 200 },
                new Product { Name = "derries", Price = 40 },
                new Product { Name = "berries", Price = 450 }
            };
            List<Product> cheapProducts = products.Where(p => p.Price < 100).ToList();

            //Console.WriteLine("\n"+products[0].Price);
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine("\n" + product.Name);
            }

            //ArrayLists
            Console.WriteLine();
            ArrayList arrlst = new ArrayList();

            arrlst.Add("hi");
            arrlst.Add(10.0);
            arrlst.Add(390);
            arrlst.Add(60.98);
            Double sum = 0;
            foreach(Object obj in arrlst)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double) {
                    sum += (double)obj; //obj is of type Object
                }
                else { }
                //Console.WriteLine(obj);
            }
            Console.WriteLine("\nsum is: "+sum);
            //same thing in lists
            Console.WriteLine();
            List<object> mixedList = new List<object>
            {
                "Hello",          // string
                42,               // int
                3.14,             // double
                true,             // bool
                new DateTime(2025, 1, 1) // DateTime
            };

            foreach (var item in mixedList)
            {
                Console.WriteLine($"{item} ({item.GetType()})");
            }

            Console.WriteLine();
            //Hashtables->can have values that are object(value will be of type ->Object
            Hashtable hashtable = new Hashtable();
            Student s1 = new Student(1, "abc", 67);
            Student s2 = new Student(2, "abcd", 68);
            Student s3 = new Student(3, "abc", 69);

            hashtable.Add(s1.Id, s1);
            hashtable.Add(s2.Id, s2);
            hashtable.Add(s3.Id, s3);

            Student stud2 = (Student)hashtable[2]; //can't assign Object type to Student, so type cast it
            Console.WriteLine(stud2.Name);

            //Nullables
            Console.WriteLine();
            int? age=null;
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("age is null");
            }

            //Dictionary
            Console.WriteLine();
            Dictionary<int,string> dict = new Dictionary<int,string>();

            dict.Add(101, "john");
            dict.Add(102, "jane");

            string name = dict[101];
            Console.WriteLine(name);

            //updating data-dict
            dict[101] = "peter";
            Console.WriteLine(dict[102] + "\n");
            dict.Remove(102);
            dict.Add(102, "king");
            dict.Add(103, "Don");
            //foreach(string i in dict.Values)
            //{
            //    Console.WriteLine(i);
            //}
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }

            //check if a key exists
            if (!dict.ContainsKey(103))
            {
                dict.Add(103, "Mike Jike");
            }
            else
            {
                Console.WriteLine("103 already exists");
            }

            //how to find at which index to add 

            int counter = 101;
            while (dict.ContainsKey(counter)) { counter++; }

            dict.Add(counter, "dave");
            Console.WriteLine(counter + " " + dict[counter]);

            bool added = dict.TryAdd(102, "mendoza"); //false
            Console.WriteLine(added);

            //adding complex objs to dict

            Dictionary<int, Student> sdict = new Dictionary<int, Student>();
            sdict.Add(1, new Student(1, "bandar", 67));
            sdict.Add(2, new Student(2, "mandar", 68));
            sdict.Add(3, new Student(3, "thunder", 69));
            foreach(var svp in sdict){
                Console.WriteLine($"\nkey: {svp.Key} value: id: {svp.Value.Id}, name: {svp.Value.Name}, score: {svp.Value.Score} ");
            }

            //Another way to initialize
            Console.WriteLine();
            var dict2 = new Dictionary<string, string>
            {
                ["TX"] = "Texas",
                ["WD"] = "WDC",
                ["LA"] = "LosAngeles"
            };
            if (dict2.TryGetValue("TX", out string state)){
                Console.WriteLine(state);
            }
        }
    }
}
