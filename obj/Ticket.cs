using System.Linq;

public class Ticket
{
    public string TicketId { get; set; }

    public string BadgeNumber { get; set; }
    public string VehicleId { get; set; }
    public string CCCD { get; set; }

    public DateTime ViolationTime { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }

    public double TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;


    public Officer Officer { get; set; }
    public Vehicle Vehicle { get; set; }
    public User User { get; set; }

    public List<TicketDetail> Details { get; set; } = new();

    public void CalculateTotalFine()
    {
        TotalAmount = Details.Sum(x => x.Violation.FineMin);
    }
    public void UpdateLicensePoints(DrivingLicense license)
    {
        foreach (var d in Details)
            license.DeductPoint(d.Violation.PenaltyPoint);
    }
}
