using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class ParksContext : DbContext
  {
    public ParksContext(DbContextOptions<ParksContext> options)
      : base(options)
      {
      }

      public DbSet<Park> Parks { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Mount PilChuck State Park", Address = "NF-4200", City = "Granite Falls", State = "WA", Zipcode = 98252, Hours = "24hrs", OpenForSeason = true, HasVisitorCenter = false, HasCamping = false},
          new Park { ParkId = 2, Name = "Wallace Falls State Park", Address = "14503 Wallace Lake Road", City = "Gold Bar", State = "WA", Zipcode = 98251, Hours = "8am - Dusk", OpenForSeason = true, HasVisitorCenter = false, HasCamping = true},
          new Park { ParkId = 3, Name = "Rasar State Park", Address = "38730 Cape Horn Road", City = "Concrete", State = "WA", Zipcode = 98237, Hours = "8am - Dusk", OpenForSeason = true, HasVisitorCenter = true, HasCamping = true},
          new Park { ParkId = 4, Name = "Crater Lake National Park", Address = "Rim Dr", City = "Crater Lake", State = "OR", Zipcode = 97604, Hours = "24hrs", OpenForSeason = true, HasVisitorCenter = true, HasCamping = true},
          new Park { ParkId = 5, Name = "Joshua Tree National Park", Address = "6554 Park Blvd",  City = "Joshua Tree", State = "CA", Zipcode = 92252, Hours = "24hrs", OpenForSeason = true, HasVisitorCenter = true, HasCamping = true},
          new Park { ParkId = 6, Name = "Sequoia National Park", Address = "47050 Generals Highway", City = "Three Rivers", State = "CA", Zipcode = 93271, Hours = "24hrs", OpenForSeason = true, HasVisitorCenter = true, HasCamping = true}
        );
      }
  }
}