using Microsoft.EntityFrameworkCore;
using OlygariaPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
//invokes the GetCart method passing in the service provider(sp)
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

// will make sure that application knows about ASP.Net Core MVC
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OlygariaPieShopDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration["ConnectionStrings:AppDbContextConnection"]);
});

var app = builder.Build();


// middleware component
// files from wwwroot
app.UseStaticFiles();

app.UseSession();

// middleware component
// show errors
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
// endpoint middleware
app.MapDefaultControllerRoute();

/*app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");*/

// seeding db
DbSeedData.Seed(app);
app.Run();
