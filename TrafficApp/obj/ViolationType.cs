namespace TrafficApp;

public class ViolationType
{
    public string ViolationTypeId { get; set; }
    public string Name { get; set; }
    public decimal FineMin { get; set; }
    public decimal FineMax { get; set; }

    public RegulationTrafficLaw Regulation { get; set; }
    public List<Violation> Violations { get; set; } = new();

    public ViolationType(string id, string name, decimal min, decimal max, RegulationTrafficLaw reg)
    {
        ViolationTypeId = id;
        Name = name;
        FineMin = min;
        FineMax = max;
        Regulation = reg;

        reg.ViolationTypes.Add(this);
    }

    public string Display()
    {
        return $"{ViolationTypeId} | {Name} | {FineMin}-{FineMax}";
    }
}
