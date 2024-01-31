using CadastroCliente_001.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var services = new ServiceCollection();

services.AddDbContext<ICadastroCliente_001Context>(options =>
    options.UseSqlServer("CadastroCliente_001Context"));

var _dbContext = services.BuildServiceProvider().GetService<ICadastroCliente_001Context>();

app.UseHttpsRedirection();
app.UseStaticFiles();

services.AddHttpContextAccessor();

builder.Services.AddScoped<ICadastroCliente_001Context, CadastroCliente_001Context>();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
