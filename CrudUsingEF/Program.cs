using CrudUsingEF.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// To read connection string from appsetting.json file
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
// Assign the connection string to ApplicationDbContext class for CRUD
builder.Services.AddDbContext<ApplicationDbContext>(op =>op.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
