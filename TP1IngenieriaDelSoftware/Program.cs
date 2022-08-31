using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TP1IngenieriaDelSoftware.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TP1IngenieriaDelSoftwareContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TP1IngenieriaDelSoftwareContext") ?? throw new InvalidOperationException("Connection string 'TP1IngenieriaDelSoftwareContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
