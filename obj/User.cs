public class User
{
    public string CCCD { get; set; }

    public string Name { get; set; }
    public DateTime? Birthday { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }

    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;


    public virtual bool Login(string cccd, string password)
    {
        return CCCD == cccd && Password == password;
    }

    public void QuickSearch() { }

    public void SearchLaw() { }
}
