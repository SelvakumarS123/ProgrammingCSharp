using UnitTestConsoleApp.Tests;

namespace UnitTestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //WorldsDumbestFunction wdf = new WorldsDumbestFunction();
            WorldsDumbestFunctionTest.WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString();
        }
    }
}
