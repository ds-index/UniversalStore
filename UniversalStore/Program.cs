using Microsoft.EntityFrameworkCore;
using UniversalStore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOp =>
    {
        sqlOp.EnableRetryOnFailure
        (
            maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(50), errorNumbersToAdd: null
        );
    });
    if(builder.Environment.IsDevelopment())
    {
        op.LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors();
    }
});

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
