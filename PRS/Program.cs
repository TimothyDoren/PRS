using PRS.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connStrKey = "PrsDbContext";

#if DEBUG
connStrKey = "PrsDbContextLocal";
#endif


builder.Services.AddDbContext<PrsDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString(connStrKey), x => x.EnableRetryOnFailure());
});
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
