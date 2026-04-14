using SeminarHallBookingAPI.Models;

namespace SeminarHallBookingAPI.Repositories;

public interface IBookingRepository{
    Task<List<SeminarBooking>> GetAllAsync();
    Task<SeminarBooking> GetByIdAsync(int id);
    Task AddAsync(SeminarBooking booking);
    Task UpdateAsync(SeminarBooking booking);
    Task DeleteAsync(int id);
}