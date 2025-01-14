namespace OOPProjectClasses
{
    public class Car
    {

        private string _model = ""; //_model is a backing field for the Model property(not needed if you're not manualy overwriting the default get,set methods of the property)
        private string _brand = "";
        //private bool _isLuxury;

        //static
        public static int NumberOfCars = 0;

        //readonly instance field-for unique IDs
        private static int nextId = 0;
        private readonly int _id = 0; //this can only get initialized(assigned a value) once(after that it can't get assigned a value anymore).

        
        //-> defaultProperty
        //public string Model { get; set; } 
        public string Model {
            get
            {
                if (IsLuxury)
                {
                    return _model + " -Luxury Edition,";
                }
                else
                {
                    return _model;
                }
            }
             set => _model = value; }


        public string Brand { get => _brand; set => _brand = value; }
        //->inside logic
        //public string Brand
        //{
        //    get => _brand;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value)) //optional logic
        //        {
        //            Console.WriteLine("you enterd nothing!");
        //            _brand = "default";
        //        }
        //        else
        //        {
        //            _brand = value; //value = whatever you enter while modifying the field, audi.Brand = "****";
        //        }
        //    }
        //}

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury { get; set; }
        public string Price { get; set; }

        //readonly property
        public int Id { get { return _id; } } //exposing the id (public) wtf


        //->constructors

        public Car(string price = "100K") {
            _id = nextId++;
            NumberOfCars++;
            Brand = "Dbrand";
            Model = "Dmodel";
            Price = price;
        }
        public Car(String brand, String model, bool isLuxury)
        {
            _id = nextId++ ;
            NumberOfCars++;
            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;
            Console.WriteLine($"brand: {Brand} & model: {Model} has been created");
        }

        //->methods

        public void Drive(string speed, string rpm)
        {
            Console.WriteLine($"model {Model} is driving at {speed} kmsh at {rpm} rpm.");
        }
        public void GetId()
        {
            Console.WriteLine($"ID of {Brand}-{Model} is {_id}");
        }
    }
}
