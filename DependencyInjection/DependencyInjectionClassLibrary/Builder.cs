using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionClassLibrary;




namespace DependencyInjectionClassLibrary
{

    //4)interface injection
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Builder: IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        //1)without DI:

        //public Builder() {
        //    _hammer = new Hammer(); //Builder depends on Hammer & Saw(builder goes and gets 'new' hammer and saw
        //    _saw = new Saw();
        //}


        //2)CONSTRUCTOR INJECTION: CONS:Dependencies can't be changed after object creation
        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer; //hammer and saw are readily given to the builder by program.cs
        //    _saw = saw;
        //}


        public void SetHammer(Hammer hammer) //4
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();

            //while using 3)Setter - > Hammer.Use(); Saw.Use();

            Console.WriteLine("House Built");
        }

        
    }
}
//3)SETTER DI-> set properties Hammer,Saw and initialize them(provide them) from the program.cs (in this case, the existing constructor and fields can be removed. Add Hammer & Saw Properties Instead)
//pros: Dependencies can be changed after object creation. cons: dependencies might not be set at the time of object creation(leading to potential null reference exceptions)

//4)Interface DI->now not just the builder but also the mechanic , plumber can use the saw and the hammer

