namespace TrafficApp;

public class Complaint
{
    public string ComplaintId { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }

    public Vehicle Vehicle { get; set; }
    public List<ComplaintHistory> Histories { get; set; } = new();

    public Complaint(string id, string description, Vehicle vehicle)
    {
        ComplaintId = id;
        Description = description;
        Status = "CHUA GIAI QUYET";
        Vehicle = vehicle;

        vehicle.Complaints.Add(this);
    }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
    }
}