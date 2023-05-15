using Classes;

Vehicle myCar = new Vehicle();
Vehicle crv = new Vehicle("Honda", "CR-V", "Dark blue", VehicleType.Spaceship);

myCar.TypeOfVehicle = VehicleType.Car;
myCar.Make = "Honda";
myCar.Model = "Civic";
myCar.Mileage = 50000;
myCar.Color = "Silver";

// Can't set isRunning because the set is private
// myCar.IsRunning = true;

myCar.TurnOn();
myCar.TurnOn();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOff();
myCar.TurnOff();

myCar.TurnOnHazards();
myCar.ClearIndicators();

myCar.IndicateRight();

myCar.TurnOn();
myCar.IndicateRight();
