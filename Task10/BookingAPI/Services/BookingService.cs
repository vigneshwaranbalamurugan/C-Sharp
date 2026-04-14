using SeminarHallBookingAPI.Models;
using SeminarHallBookingAPI.Repositories;

namespace SeminarHallBookingAPI.Services;

public class BookingService : IBookingService{
    private readonly IBookingRepository _repository;

    public BookingService(IBookingRepository repository){
        _repository = repository;
    }

    public async Task<List<SeminarBooking>> GetBookings(){
        return await _repository.GetAllAsync();
    }

    public async Task<SeminarBooking> GetBooking(int id){
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddBooking(SeminarBooking booking){
        await _repository.AddAsync(booking);
    }

    public async Task UpdateBooking(SeminarBooking booking){
        await _repository.UpdateAsync(booking);
    }

    public async Task DeleteBooking(int id){
        await _repository.DeleteAsync(id);
    }
}