namespace TrafficApp;

public class DrivingLicense
{
    public string LicenseNo { get; set; }
    public string Class { get; set; }
    public string Status { get; set; }

    public User User { get; set; }
    public Vehicle Vehicle { get; set; }

    public DrivingLicense(string no, string cls, User user, Vehicle vehicle)
    {
        LicenseNo = no;
        Class = cls;
        User = user;
        Vehicle = vehicle;
        Status = "CÒN HẠN";
    }

    public string Display()
    {
        return $"{LicenseNo} | {Class} | {Status}";
    }
}

