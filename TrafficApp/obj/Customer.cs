namespace TrafficApp;

public class Customer : User
{
    public Customer(string id, string n, string p, string email, string pass = "")
        : base(id, n, p, email, pass)
    {
        role_pos = "KHÁCH HÀNG";
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
