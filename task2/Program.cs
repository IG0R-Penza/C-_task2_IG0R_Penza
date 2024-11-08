Car mers = new Car("Mersedes", "B156TA77");
Bicycle bmx = new Bicycle("WeThePeople", "chromium-molybdenum");
mers.drive();
bmx.ride();
class Vehicle
{
    private string _name="";
    public string Name { 
        get { return _name; } 
        set { _name = value; }
    }
    public Vehicle(string name) { Name = name; }
}

class Car : Vehicle
{
    private string _LicencePlate = "";
    public string LicensePlate
    {
        get { return _LicencePlate; }
        set { _LicencePlate = value; }
    }
    public Car(string name, string licenseplate)
        : base(name)
    {
        LicensePlate = licenseplate;
    }
    public void drive()
    {
        Console.WriteLine($"Driving {this.Name}, {_LicencePlate}");
    }
}

class Bicycle : Vehicle
{
    private string _FrameMaterial = "";
    public string FrameMaterial
    {
        get { return _FrameMaterial; }
        set { _FrameMaterial = value; }
    }
    public Bicycle(string name, string framematerial)
        : base(name)
    {
        FrameMaterial = framematerial;
    }
    public void ride()
    {
        Console.WriteLine($"Riding {this.Name} with {_FrameMaterial} frame");
    }
}