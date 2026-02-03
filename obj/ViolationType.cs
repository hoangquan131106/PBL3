public class ViolationType
{
    public string ViolationId { get; set; }

    public string RegulationId { get; set; }

    public string Name { get; set; }
    public string LawClause { get; set; }
    public string VehicleType { get; set; }

    public double FineMin { get; set; }
    public double FineMax { get; set; }

    public int PenaltyPoint { get; set; }

    public string AdditionalPenalty { get; set; }

    public TrafficLaw Law { get; set; }
}
