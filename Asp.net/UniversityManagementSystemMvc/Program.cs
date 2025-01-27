using Microsoft.EntityFrameworkCore;
using UniversityManagementSystemMvc.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UniversityManagementSystemMvcContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
