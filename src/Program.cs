using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(o =>
{
    o.UseSqlite("Data Source=app.db");
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
