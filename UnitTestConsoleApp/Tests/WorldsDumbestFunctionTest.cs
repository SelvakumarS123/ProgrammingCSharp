using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleApp.Tests
{
    public class WorldsDumbestFunctionTest
    {
        //ClassName_MethodName_ExpectedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange-go get your variables, whatever u need(classes,functions etc) for this function to actually run.
                int n = 0;
                WorldsDumbestFunction wdf = new WorldsDumbestFunction();
                //Act-execute this function
                string result = wdf.ReturnsPikachuIfZero(n);
                //Assert - whaterver is returned by the function, is it what you want?.
                if (result == "Pika pika")
                {
                    Console.WriteLine("PASSED");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
