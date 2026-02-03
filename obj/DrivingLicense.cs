public class DrivingLicense
{
    public string LicenseId { get; set; }

    public string CCCD { get; set; }
    public string VehicleId { get; set; }

    public string Class { get; set; }

    public DateTime? IssueDate { get; set; }
    public DateTime? ExpiryDate { get; set; }

    public int CurPoint { get; set; }

    public string Status { get; set; }

    public User User { get; set; }


    public void DeductPoint(int point)
    {
        CurPoint -= point;

        if (CurPoint <= 0)
            Status = "Tước quyền sử dụng";
    }
}

