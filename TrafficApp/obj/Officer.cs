namespace TrafficApp;

public class Officer : User
{
    public string BadgeNumber { get; set; }
    public string Unit { get; set; }
    public string Rank { get; set; }

    public Officer(string id, string n, string p, string email,
                   string badge, string unit, string rank, string pass = "")
        : base(id, n, p, email, pass)
    {
        BadgeNumber = badge;
        Unit = unit;
        Rank = rank;
        role_pos = "CẢNH SÁT";
    }

    public override string GetRole()
    {
        return role_pos;
    }

    public override string Display()
    {
        return base.Display() + $" | {BadgeNumber} | {Unit} | {Rank}";
    }
}
