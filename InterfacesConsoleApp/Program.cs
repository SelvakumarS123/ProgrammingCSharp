using InterfaceAppCL;

namespace InterfacesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("waffle");
        }
    }
}
