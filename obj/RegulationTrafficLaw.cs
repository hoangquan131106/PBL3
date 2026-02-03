public class TrafficLaw
{
    public string RegulationId { get; set; }

    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime? EffectiveDate { get; set; }

    public List<ViolationType> ViolationTypes { get; set; }
}

