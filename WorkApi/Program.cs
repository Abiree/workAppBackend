using Business.IServices;
using Business.Services;
using Data;
using Data.IRepositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using workApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Connection to database
var ConnectionStrings = builder.Configuration.GetConnectionString("sqlConnection");

builder.Services.AddDbContext<DataContext>(Opt => Opt.UseNpgsql(ConnectionStrings, b => b.MigrationsAssembly("Data")));

// Add services to the container.
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.RegisterConfigurationManager();
//Configure JWT
builder.Services.ConfigureJWT(builder.Configuration);


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserActivityService, UserActivityService>();
builder.Services.AddScoped<IActivityRepository, ActivityRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
        {
            options.AddPolicy("MyPolicy", builder =>
            {
                builder.WithOrigins("*") // Allow requests from this origin
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
        });

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors("MyPolicy"); // Use the CORS policy defined earlier

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
