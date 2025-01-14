namespace ConstructorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("joe", 36, 1314, "SystemArchitect");
            joe.DisplayEmployeeInfo();
            Console.WriteLine();
            Manager jagdish = new Manager("Jagdish", 49, 8765," DPS", 45);
            jagdish.DisplayManagerInfo();
        }
    }
    public class Person
    {
        public int Age { get; private set; }
        public string Name { get; private set; } //nobody else can set the name except the person class

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("personconstructor");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee:Person
    {
        public int EmployeeID { get; private set; }
        public string JobTitle { get; private set; }

        public Employee(String name, int age, int employeeID, string jobTitle):base(name,age)
        {
            EmployeeID = employeeID;
            JobTitle = jobTitle;
            Console.WriteLine("employeeconstructor");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}, JobTitle: {JobTitle}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, int employeeID, string jobTitle, int teamSize) : base(name, age, employeeID, jobTitle)
        {
            TeamSize = teamSize;
            Console.WriteLine("managerconstructor");
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
        
        
    }
}
