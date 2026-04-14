using Microsoft.EntityFrameworkCore;
using SeminarHallBookingAPI.Data;
using SeminarHallBookingAPI.Middleware;
using SeminarHallBookingAPI.Repositories;
using SeminarHallBookingAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("SeminarDB"));

builder.Services.AddScoped<IBookingRepository,
    BookingRepository>();

builder.Services.AddScoped<IBookingService,
    BookingService>();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();