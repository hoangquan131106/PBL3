namespace TrafficApp;

public class RegulationTrafficLaw
{
    public string RegulationId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }

    public List<ViolationType> ViolationTypes { get; set; } = new();

    public RegulationTrafficLaw(string id, string code, string name)
    {
        RegulationId = id;
        Code = code;
        Name = name;
    }
}
