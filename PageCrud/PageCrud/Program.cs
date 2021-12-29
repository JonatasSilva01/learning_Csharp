using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PageCrud.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<PageCrudContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PageCrudContext")));

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
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
