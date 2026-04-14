using SeminarHallBookingAPI.Models;

namespace SeminarHallBookingAPI.Services;

public interface IBookingService{
    Task<List<SeminarBooking>> GetBookings();
    Task<SeminarBooking> GetBooking(int id);
    Task AddBooking(SeminarBooking booking);
    Task UpdateBooking(SeminarBooking booking);
    Task DeleteBooking(int id);
}