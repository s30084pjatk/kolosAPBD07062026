using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<_2019sbdContext>(options =>
    options.UseSqlServer(
        "Server=db-mssql.pjwstk.edu.pl;Database=2019sbd;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"));
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();