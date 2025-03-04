using DotNetCoreSqlDb.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["AZURE_SQL_CONNECTIONSTRING"];

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.Run();
