namespace TrafficApp;

public class User
{
    public string UserId { get; set; }
    public string CCCD { get; set; }
    public string FullName { get; set; }
    public string Role { get; set; }

    public List<Vehicle> Vehicles { get; set; } = new();
    public List<ComplaintHistory> HandledHistories { get; set; } = new();

    public User(string id, string cccd, string name, string role)
    {
        UserId = id;
        CCCD = cccd;
        FullName = name;
        Role = role;
    }

    public string GetRole()
    {
        return Role;
    }
}