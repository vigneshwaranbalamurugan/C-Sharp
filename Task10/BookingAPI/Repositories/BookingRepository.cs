using Microsoft.EntityFrameworkCore;
using SeminarHallBookingAPI.Data;
using SeminarHallBookingAPI.Models;

namespace SeminarHallBookingAPI.Repositories;

public class BookingRepository : IBookingRepository{
    private readonly AppDbContext _context;

    public BookingRepository(AppDbContext context){
        _context = context;
    }

    public async Task<List<SeminarBooking>> GetAllAsync(){
        return await _context.Bookings.ToListAsync();
    }

    public async Task<SeminarBooking> GetByIdAsync(int id){
        return await _context.Bookings.FindAsync(id);
    }

    public async Task AddAsync(SeminarBooking booking){
        await _context.Bookings.AddAsync(booking);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SeminarBooking booking){
        _context.Bookings.Update(booking);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id){
        var booking = await _context.Bookings.FindAsync(id);

        if (booking != null){
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }
}