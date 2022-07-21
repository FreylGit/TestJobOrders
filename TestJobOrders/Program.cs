using Microsoft.EntityFrameworkCore;
using TestJobOrders.Data;
using TestJobOrders.Data.InterfaceData;
using TestJobOrders.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
//Настройка базы данных
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
