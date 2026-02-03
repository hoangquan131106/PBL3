namespace TrafficApp;

public class Violation
{
    public string ViolationId { get; set; }
    public string TicketId { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }

    public Officer Officer { get; set; }
    public Vehicle Vehicle { get; set; }
    public ViolationType ViolationType { get; set; }

    public List<PaymentHistory> Payments { get; set; } = new();
    public List<Complaint> Complaints { get; set; } = new();

    public Violation(string id, string ticket, Officer officer, Vehicle vehicle, ViolationType type)
    {
        ViolationId = id;
        TicketId = ticket;
        Officer = officer;
        Vehicle = vehicle;
        ViolationType = type;

        Status = "CHƯA THANH TOÁN";
        TotalAmount = type.FineMax;

        officer.Violations.Add(this);
        vehicle.Violations.Add(this);
        type.Violations.Add(this);
    }

    public string Display()
    {
        return $"{TicketId} | {Vehicle.PlateNumber} | {TotalAmount} | {Status}";
    }
}
