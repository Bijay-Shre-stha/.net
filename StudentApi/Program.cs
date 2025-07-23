using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// ✅ Use MySQL with correct provider
var connectionString = "server=localhost;database=studentdb;user=root;password=;";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(connectionString)); // ← UseMySQL, not UseSqlServer

var app = builder.Build();

// Configure pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
