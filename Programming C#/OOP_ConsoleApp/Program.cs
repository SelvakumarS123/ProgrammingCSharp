using OOPProjectClasses;

namespace OOP_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("audi", "A5", true);
            Car bmw = new Car("bmw", "Q7", false);

            //->modifying a field using property
            //Console.WriteLine("enter ");
            //audi.Brand=Console.ReadLine();
            //Console.WriteLine($"u entered {audi.Brand}");

            //->using default constructor(no arguments)
            Car suzuki = new Car();
            Console.WriteLine(suzuki.Brand); //prints "Dbrand"
            suzuki.Brand = "Suzuki";
            suzuki.Model = "Swift";
            Console.WriteLine(suzuki.Brand);

            //->methods
            suzuki.Drive(rpm:"200", speed:"7000");
            audi.Drive("9000", "400");

            //->default parameters(on constructors)
            Car nissan = new Car();
            Console.WriteLine("\nnissan: " + nissan.Brand + " " + nissan.Price);

            //static
            Console.WriteLine(Car.NumberOfCars);
            audi.GetId();
            bmw.GetId();
            suzuki.GetId();
            nissan.GetId();

            //readonly ids exposed by public property
            Console.WriteLine(nissan.Id);
        }
    }
}
