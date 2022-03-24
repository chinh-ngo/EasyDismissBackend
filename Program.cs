using Backend.Data;
using Backend.Helpers;
using Backend.Hubs;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var dbCString = builder.Configuration.GetConnectionString("EasyDismiss");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EDDbContext>(opts => opts.UseSqlServer(dbCString));

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .WithMethods("GET", "POST")
                .AllowCredentials();
        });
});

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<StudentsService>();
builder.Services.AddScoped<RoomsService>();
builder.Services.AddScoped<CarlinesService>();
builder.Services.AddSignalR();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapHub<DispatchHub>("/room");

app.MapControllers();

app.Run();

