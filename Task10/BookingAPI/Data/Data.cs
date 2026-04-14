using Microsoft.EntityFrameworkCore;
using SeminarHallBookingAPI.Models;

namespace SeminarHallBookingAPI.Data;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions options): base(options){
    }

    public DbSet<SeminarBooking> Bookings { get; set; }
}