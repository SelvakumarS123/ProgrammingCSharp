using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //// Create an instance of the Delegates class
            //Delegates delegatesExample = new Delegates();

            //// Call the instance method RunDelegateDemo
            //delegatesExample.RunDelegateDemo();





            //generics
            //Box<int> box = new Box<int>();
            //box.Content = 1;
            //Console.WriteLine(box.Log());

            //Box<string> box2 = new Box<string>();
            //box2.Content = "hello";
            //Console.WriteLine(box2.Log());

            Box<string> box2 = new Box<string>("hello world");

            box2.UpdateContent("hello mars\n");

            Console.WriteLine(box2.GetContent());

            //MultipleGenericTypes in a class

            MultipleGenTypes<string, int> multipleGenTypes = new MultipleGenTypes<string, int>("One hundred", 100);
            multipleGenTypes.Display();


            GenMethodsInsideNonGenClass genMethodsInsideNonGenClass = new GenMethodsInsideNonGenClass();
            genMethodsInsideNonGenClass.Log<int>(10);

            genMethodsInsideNonGenClass.Log<string>("\n200");

            genMethodsInsideNonGenClass.Log(new { Name = "Selva", Age = 22 }); //you can pass anything (even in-line styled objects like this)

        }
        
    }
}
