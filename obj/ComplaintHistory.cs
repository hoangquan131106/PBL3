namespace TrafficApp;

public class ComplaintHistory
{
    public string HistoryId { get; set; }
    public string Action { get; set; }
    public string Note { get; set; }

    public User Handler { get; set; }
    public Complaint Complaint { get; set; }

    public ComplaintHistory(string id, Complaint c, User handler, string action, string note)
    {
        if (handler.GetRole() != "ADMIN" && handler.GetRole() != "CẢNH SÁT")
            throw new Exception("Không có quyền xử lý khiếu nại");

        HistoryId = id;
        Complaint = c;
        Handler = handler;
        Action = action;
        Note = note;

        c.Histories.Add(this);
    }

    public string Display()
    {
        return $"{HistoryId} | {Handler.GetRole()} | {Action} | {Note}";
    }
}

