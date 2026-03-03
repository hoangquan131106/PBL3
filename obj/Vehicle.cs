namespace TrafficApp;

public class Vehicle
{
    public string VehicleId { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public string EngineNum { get; set; }
    public string ChassisNum { get; set; }
    public DateTime? RegDate { get; set; }

    public User Owner { get; set; }
    public List<Complaint> Complaints { get; set; } = new();

    public Vehicle(string id, string brand, string type, string color, User owner)
    {
        VehicleId = id;
        Brand = brand;
        Type = type;
        Color = color;
        Owner = owner;

        owner.Vehicles.Add(this);
    }
}