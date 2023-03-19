using OlygariaPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

// will make sure that application knows about ASP.Net Core MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();


// middleware component
// files from wwwroot
app.UseStaticFiles();

// middleware component
// show errors
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
// endpoint middleware
app.MapDefaultControllerRoute();

app.Run();
