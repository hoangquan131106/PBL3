public class Vehicle
{
    public string VehicleId { get; set; }

    public string CCCD { get; set; }

    public string Brand { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public string EngineNum { get; set; }
    public string ChassisNum { get; set; }
    public DateTime? RegDate { get; set; }

    public User Owner { get; set; }
}

