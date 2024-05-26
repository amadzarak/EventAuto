using Microsoft.EntityFrameworkCore;
using EventAuto.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EventContext>(opt =>
    opt.UseInMemoryDatabase("EventList"));
builder.Services.AddDbContext<ProfileContext>(opt =>
    opt.UseInMemoryDatabase("Profiles"));
builder.Services.AddDbContext<VenueContext>(opt =>
    opt.UseInMemoryDatabase("VenueList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
