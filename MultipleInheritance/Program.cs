namespace MultipleInheritance
{
    public interface IPrintable
    {
        void Print();
    }
    public interface IScannable
    {
        void Scan();
    }

    public class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print() { Console.WriteLine("Printing doc"); }
        public void Scan() { Console.WriteLine("Scanning doc"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter printer = new MultiFunctionPrinter();
                printer.Print();
                printer.Scan();
        }
    }
}
