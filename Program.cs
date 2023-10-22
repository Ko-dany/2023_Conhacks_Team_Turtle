using Microsoft.EntityFrameworkCore;
using Team_Turtle.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// configure sessions:
builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    // set the session duration to 5mins
    options.IdleTimeout = TimeSpan.FromMinutes(5);
});

var connStr = builder.Configuration.GetConnectionString("SWCDB");
builder.Services.AddDbContext<SWCDbContext>(options => options.UseSqlServer(connStr));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// and use sessions in the middleware pipeline:
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
