using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Streams.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
	builder.Services.AddSwaggerGen(c => {
	c.AddServer(new OpenApiServer
	{
		Description = "Development server",
		Url = "http://localhost:7176"

	});
});


#region DataBase


string? ConnectionString = builder.Configuration.GetConnectionString("Stream");

builder.Services.AddDbContext<StreamContext>(options => options.UseSqlServer(ConnectionString));




#endregion





var app = builder.Build();

app.UseCors(builder => builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());
app.UseSwagger().UseSwaggerUI();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
