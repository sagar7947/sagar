using Microsoft.AspNetCore.Mvc;
using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICounter, CommonCounter>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
