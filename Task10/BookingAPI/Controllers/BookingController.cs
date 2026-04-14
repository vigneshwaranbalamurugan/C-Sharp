using Microsoft.AspNetCore.Mvc;
using SeminarHallBookingAPI.Models;
using SeminarHallBookingAPI.Services;

namespace SeminarHallBookingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase{
    private readonly IBookingService _service;
    private readonly ILogger<BookingController> _logger;

    public BookingController(
        IBookingService service,
        ILogger<BookingController> logger){
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetBookings(){
        _logger.LogInformation("Fetching all bookings");

        var bookings = await _service.GetBookings();

        return Ok(bookings);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooking(int id){
        var booking = await _service.GetBooking(id);

        if (booking == null)
            return NotFound();

        return Ok(booking);
    }

    [HttpPost]
    public async Task<IActionResult> AddBooking(SeminarBooking booking){
        await _service.AddBooking(booking);

        return Ok("Booking Added Successfully");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBooking(SeminarBooking booking){
        await _service.UpdateBooking(booking);

        return Ok("Booking Updated Successfully");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id){
        await _service.DeleteBooking(id);

        return Ok("Booking Deleted Successfully");
    }
}