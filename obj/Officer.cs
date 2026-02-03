public class Officer : User
{
    public string BadgeNumber { get; set; }
    public string Rank { get; set; }
    public string Unit { get; set; }
    public string PassHash { get; set; }


  
    public bool LoginByBadge(string badge, string hash)
    {
        return BadgeNumber == badge && PassHash == hash;
    }
}

