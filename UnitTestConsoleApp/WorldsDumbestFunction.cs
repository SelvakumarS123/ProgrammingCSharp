using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleApp
{
    public class WorldsDumbestFunction
    {
        public string ReturnsPikachuIfZero(int n)
        {
            if(n == 0)
            {
                return "Pika pika";
            }
            else
            {
                return "ding ding";
            }
        }
    }
}
