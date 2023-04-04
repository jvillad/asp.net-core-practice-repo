using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlygariaPieShop.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
//invokes the GetCart method passing in the service provider(sp)
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();


builder.Services.AddControllersWithViews().AddJsonOptions(options =>
{
	options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddRazorPages();

// will make sure that application knows about ASP.Net Core MVC
builder.Services.AddDbContext<OlygariaPieShopDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration["ConnectionStrings:AppDbContextConnection"]);
});

/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)*/
builder.Services.AddDefaultIdentity<IdentityUser>()
	.AddEntityFrameworkStores<OlygariaPieShopDbContext>();

builder.Services.AddServerSideBlazor();

var app = builder.Build();

// middleware component
// files from wwwroot
app.UseStaticFiles();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
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
app.MapRazorPages();

app.MapBlazorHub();
app.MapFallbackToPage("/app/{*catchall}", "/App/Index");

// routing to build an API
app.MapControllers();

// seeding db
DbSeedData.Seed(app);
app.Run();
