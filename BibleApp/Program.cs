using BibleApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddHttpClient("BibleApi", config =>
{
    var baseAddress = builder.Configuration.GetValue<string>("BibleApi:BaseUrl");
    var apiKey = builder.Configuration.GetValue<string>("BibleApi:Key");

    config.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BibleApi:BaseUrl"));
    config.DefaultRequestHeaders.Add("api-key", apiKey);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
