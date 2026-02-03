public class Complaint
{
    public string ComplaintId { get; set; }

    public string TicketId { get; set; }
    public string CCCD { get; set; }

    public string Content { get; set; }
    public string Status { get; set; }

    public Ticket Ticket { get; set; }
    public User User { get; set; }
}
