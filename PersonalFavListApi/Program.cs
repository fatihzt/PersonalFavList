using PersonalFavListApi.Controllers;
using PFL.Business.Abstract;
using PFL.Business.Concrete;
using PFL.Core.Abstract;
using PFL.Core.Concrete;
using PFL.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ICustomer, EfCustomer>();
builder.Services.AddScoped<IFavoriteListService, FavoriteListManager>();
builder.Services.AddScoped<IFavoriteList, EfFavoriteList>();
builder.Services.AddScoped<IMovieService, MovieManager>();
builder.Services.AddScoped<IMovie, EfMovie>();
builder.Services.AddScoped<ISongService, SongManager>();
builder.Services.AddScoped<ISong, EfSong>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
