
namespace ClassLibrary
{
    public delegate void Notify(string message); //can also declare here so that all classes can use it
    public class Delegates
    {

        //do not add a body to  a delegate
        // Delegates define a method signature
        // Any method assigned to a delegate must match this signature
        public delegate void Notify(string message); // Declaration of the delegate

        // A static method that matches the delegate signature
        static void ShowMsg(string message)
        {
            Console.WriteLine(message);
        }

        // A method to demonstrate instantiation and invocation of the delegate
        public void RunDelegateDemo()
        {
            // Instantiation: Assign the method to the delegate
            Notify notifyDelegate = ShowMsg;

            // Invocation: Call the method through the delegate
            notifyDelegate("Hello from the delegate!");
        }
    }
}

