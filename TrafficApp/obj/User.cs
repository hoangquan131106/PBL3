namespace TrafficApp;

public abstract class User
{
    protected string role_pos;

    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Vehicle> Vehicles { get; set; } = new();
public List<DrivingLicense> DrivingLicenses { get; set; } = new();
public List<Complaint> Complaints { get; set; } = new();
public List<Notification> Notifications { get; set; } = new();


    protected User(string id, string n, string p, string email, string pass = "")
    {
        Id = id;
        Name = n;
        Phone = p;
        Email = email;
        Password = pass;
    }

    public virtual string GetRole()
    {
        return role_pos;
    }

    public virtual string Display()
    {
        return $"{Id} | {Name} | {Phone} | {Email} | {role_pos}";
    }
    

}
