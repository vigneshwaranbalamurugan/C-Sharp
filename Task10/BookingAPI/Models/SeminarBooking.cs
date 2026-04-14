namespace SeminarHallBookingAPI.Models;

public class SeminarBooking{
    public int Id { get; set; }
    public string HallName { get; set; }
    public string BookedBy { get; set; }
    public DateTime Date { get; set; }
    public string TimeSlot { get; set; }
}