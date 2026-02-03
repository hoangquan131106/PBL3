public class PaymentHistory
{
    public string PaymentId { get; set; }

    public string TicketId { get; set; }
    public string CCCD { get; set; }
    public string VehicleId { get; set; }

    public double Amount { get; set; }
    public string Method { get; set; }

    public DateTime Date { get; set; }

    public Ticket Ticket { get; set; }
}
