using Classes; // using directive

// type name = new type constructor
Classes.Donut boston = new Classes.Donut("Jelly Filled");
Console.WriteLine(boston.GetDonutType());

// A Donut class instance called cream
// It uses the using statement to access the Donut class
Donut cream = new Donut("Boston Cream"); // Declare an instance of Donut
Console.WriteLine(cream.GetDonutType());

// Assigning a value to donutType field
// cream.donutType = "Chocolate Cream";
cream.SetDonutType("Chocolate Cream");

string type = cream.GetDonutType();
Console.WriteLine(type);

cream.Filling = "Cream"; // set
Console.WriteLine(cream.Filling); // get

cream.Topping = "glaze"; // set
Console.WriteLine(cream.Topping); // get

cream.IsOnSpecial = false;
cream.Price = 1.50;

namespace Classes
{
    class Donut
    {
        // Field
        // The access modifier is our public/private
        private string donutType;

        // Backing field
        // Starting fields with _ is a naming convention
        private string? _topping;

        // Constructor
        public Donut(string type)
        {
            // assigning our constructor parameter to the field.
            // Whatever is passed into the constructor
            // passes its value to the field.
            donutType = type;
            // this.donutType = type;
        }

        // Properties
        // public -> Access Modifier
        // string? -> Property type
        // Filling -> Property name
        // { get; set; } -> Accessors
        public string? Filling { get; set; }
        public double Price { get; set; }
        public bool IsOnSpecial { get; set; }
        public string? Topping
        {
            // The function/method that is executed when you read from the property
            get
            {
                return _topping;
            }
            set
            {
                // property = "..." -> "..." is represented as value
                // Donut.Topping = value;
                _topping = value?.ToUpper(); // optional chaining
            }
        }

        // Method (A function inside an object)
        // public -> Access Modifier
        // string -> Return Type
        // GetDonutType -> Method name
        // () -> group of parameters, no params means it is empty
        // GetDonutType() -> Method Signature, must be unique -> name + parameters
        public string GetDonutType()
        {
            // Returns our above field
            return donutType;
            // return this.donutType;
        }

        public void SetDonutType(string newType)
        {
            donutType = newType;
        }
    }
}