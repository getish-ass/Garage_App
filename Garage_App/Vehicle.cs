
public abstract class Vehicle
{
    public string? RegisterNumber { get; set; }
    //public string? VehicleType { get; set; }
    public string? Color { get; set; }
    public int NumberOfWheels { get; set; }

    public Vehicle(string regnr, string color, int nrofWheels)
    {
        RegisterNumber = regnr;
        Color = color;
        NumberOfWheels = nrofWheels;
    }

    public override string ToString()
    {
        return $"Register Num.: {RegisterNumber}, Vehicle Col.:{Color} Number Of Wheels: {NumberOfWheels}";
    }

}