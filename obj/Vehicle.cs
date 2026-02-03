namespace TrafficApp;

public class Vehicle
{
    public string VehicleId { get; set; }
    public string PlateNumber { get; set; }
    public string Type { get; set; }
    public string Brand { get; set; }

    public User Owner { get; set; }
    public List<Violation> Violations { get; set; } = new();

    public Vehicle(string id, string plate, string type, string brand, User owner)
    {
        VehicleId = id;
        PlateNumber = plate;
        Type = type;
        Brand = brand;
        Owner = owner;
    }

    public string Display()
    {
        return $"{VehicleId} | {PlateNumber} | {Type} | {Brand}";
    }
}
