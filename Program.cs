using Hydro.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddHydro();
builder.Services.AddHydro(options => { options.AntiforgeryTokenEnabled = true; });
var app = builder.Build();

app.MapRazorPages();
app.UseStaticFiles();
app.UseRouting();
app.UseHydro(app.Environment);

app.Run();