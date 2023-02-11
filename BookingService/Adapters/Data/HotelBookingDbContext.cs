using Domain.Entitities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class HotelBookingDbContext: DbContext
    {
        public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options): base(options) { }

        DbSet<Guest> Guests { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Room> Rooms { get; set; }
    }
}