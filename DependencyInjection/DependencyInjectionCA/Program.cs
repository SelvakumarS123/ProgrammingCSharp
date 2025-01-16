using DependencyInjectionClassLibrary;

namespace DependencyInjectionCA //DI-used to achieve inversion of control-MAKING A CLASS INDEPENDENT OF IT'S DEPENDENCIES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();

            //CONSTRUCTOR DI
            //Builder builder = new Builder(hammer,saw);
            //builder.BuildHouse();

            //SETTER DI - inject dependencies via setters
            //builder.Hammer = hammer;
            //builder.Saw  = saw;

            //InterfaceDI
            Builder builder1 = new Builder();
            builder1.SetSaw(saw);
            builder1.SetHammer(hammer);
            builder1.BuildHouse();
        }
    }
}
