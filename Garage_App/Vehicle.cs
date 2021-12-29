// See https://aka.ms/new-console-template for more information
public class Vehicle
{
    public string? RegisterNumber { get; set; }
    public string? VehicleType { get; set; }
    public string? VehicleColor { get; set; }
    public int NumberOfWheel { get; set; }

    public override string ToString()
    {
        return $"Register Num.: {RegisterNumber} Vehicle Typ.:{VehicleType} Vehicle Col.:{VehicleColor} Number Of Wheels: {NumberOfWheel}";
    }

}