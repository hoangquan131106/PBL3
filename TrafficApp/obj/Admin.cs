namespace TrafficApp;

public class Admin : User
{
    public Admin(string id, string n, string p, string email, string pass = "")
        : base(id, n, p, email, pass)
    {
        role_pos = "ADMIN";
    }

    public override string GetRole()
    {
        return role_pos;
    }

    public override string Display()
    {
        return base.Display();
    }
}
