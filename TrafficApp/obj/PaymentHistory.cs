namespace TrafficApp;

public class PaymentHistory
{
    public string PaymentId { get; set; }
    public decimal Amount { get; set; }
    public string Method { get; set; }

    public Violation Violation { get; set; }

    public PaymentHistory(string id, Violation v, decimal amount, string method)
    {
        PaymentId = id;
        Violation = v;
        Amount = amount;
        Method = method;

        v.Payments.Add(this);
    }

    public string Display()
    {
        return $"{PaymentId} | {Amount} | {Method}";
    }
}
