using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Officer> Officers { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<TrafficLaw> TrafficLaws { get; set; }
    public DbSet<ViolationType> ViolationTypes { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketDetail> TicketDetails { get; set; }
    public DbSet<DrivingLicense> DrivingLicenses { get; set; }
    public DbSet<Complaint> Complaints { get; set; }
    public DbSet<PaymentHistory> PaymentHistories { get; set; }
    public DbSet<Notification> Notifications { get; set; }


    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Officer>().HasBaseType<User>();

        model.Entity<Vehicle>()
            .HasOne(v => v.Owner)
            .WithMany();

        model.Entity<ViolationType>()
            .HasOne(v => v.Law)
            .WithMany(l => l.ViolationTypes);

        model.Entity<TicketDetail>()
            .HasKey(x => new { x.TicketId, x.ViolationId });
    }
}
