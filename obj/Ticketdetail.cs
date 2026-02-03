public class TicketDetail
{
    public string TicketId { get; set; }
    public string ViolationId { get; set; }

    public Ticket Ticket { get; set; }
    public ViolationType Violation { get; set; }
}

