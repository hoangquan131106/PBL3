namespace TrafficApp;

public class Notification
{
    public string NotificationId { get; set; }
    public string Content { get; set; }
    public string Type { get; set; }

    public User User { get; set; }

    public Notification(string id, User user, string content, string type)
    {
        NotificationId = id;
        User = user;
        Content = content;
        Type = type;
    }

    public string Display()
    {
        return $"{NotificationId} | {Content}";
    }
}
