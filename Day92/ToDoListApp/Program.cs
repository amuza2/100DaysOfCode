using Microsoft.EntityFrameworkCore;
using ToDoListApp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(opt =>
{
    opt.Conventions.AddPageRoute("/Tasks/Index", "");
});

builder.Services.AddDbContext<ToDoDbContext>(opt => opt.UseSqlite("DataSource=Data/ToDoList.db"));

var app = builder.Build();

// Add middleware

// Configure the HTTP request pipeline.
app.UseMiddleware<RequestLoggingMiddleware>();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
