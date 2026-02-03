namespace TrafficApp;

public class Complaint
{
    public string ComplaintId { get; set; }
    public string Content { get; set; }
    public string Status { get; set; }

    public User User { get; set; }
    public Violation Violation { get; set; }

    public List<ComplaintHistory> Histories { get; set; } = new();

    public Complaint(string id, User user, Violation v, string content)
    {
        ComplaintId = id;
        User = user;
        Violation = v;
        Content = content;
        Status = "ĐANG XỬ LÝ";

        v.Complaints.Add(this);
    }

    public string Display()
    {
        return $"{ComplaintId} | {Status} | {Content}";
    }
}

