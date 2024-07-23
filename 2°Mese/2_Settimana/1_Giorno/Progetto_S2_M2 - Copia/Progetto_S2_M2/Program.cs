using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using Soluzione_S2_M2.Connessione;
using Soluzione_S2_M2.Login;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .RegisterDAOs()
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.LoginPath = "/Login/Login";
        opt.AccessDeniedPath = "/Negate/Negate";
    });

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DbContextConn>();
builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
