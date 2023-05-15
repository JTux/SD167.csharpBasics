namespace Classes;

public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Boat, Plane }

// accessModifier class ClassName
public class Vehicle
{
    // Constructor Overloading
    public Vehicle()
    {
        Make = "Honda";
        Model = "Civic";
        Color = "Silver";
        TypeOfVehicle = VehicleType.Car;
    }
    public Vehicle(string make, string model, string color, VehicleType type)
    {
        // Property = parameter
        Make = make;
        Model = model;
        Color = color;
        TypeOfVehicle = type;
    }

    // Properties
    // Make, Model, Mileage, Color
    // accessModifier type name { accessors; }
    public string Make { get; set; }
    public string Model { get; set; }
    public double Mileage { get; set; }
    public string Color { get; set; }
    public VehicleType TypeOfVehicle { get; set; }

    // Property with a private set (only change it in the class)
    public bool IsRunning { get; private set; }

    public Indicator RightIndicator { get; } = new Indicator("right");
    public Indicator LeftIndicator { get; } = new Indicator("left");

    // Methods (Actions)
    // AccessModifier returnType Name(parameters)
    public void TurnOn()
    {
        if (IsRunning == false) //!IsRunning
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }
        else
        {
            Console.WriteLine("The vehicle is already on.");
        }
    }
    public void TurnOff()
    {
        if (IsRunning) // IsRunning == true
        {
            IsRunning = false;
            Console.WriteLine("You turn the vehicle off.");
        }
        else
        {
            Console.WriteLine("The vehicle is already off.");
        }
    }

    // Indicate Right
    public void IndicateRight()
    {
        if (IsRunning && !RightIndicator.IsFlashing)
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
    }
    // Indicate Left
    public void IndicateLeft()
    {
        if (IsRunning && !LeftIndicator.IsFlashing)
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }
    }
    // Turn on Hazards
    public void TurnOnHazards()
    {
        RightIndicator.TurnOn();
        LeftIndicator.TurnOn();
    }
    // Clear all indicators
    public void ClearIndicators()
    {
        RightIndicator.TurnOff();
        LeftIndicator.TurnOff();
    }
}
