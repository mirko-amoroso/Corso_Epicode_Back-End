using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Service;

var builder = WebApplication.CreateBuilder(args);

// Aggiungi servizi al contenitore
builder.Services.AddControllersWithViews();

// Stringa di connessione utilizzata
var conn = builder.Configuration.GetConnectionString("SqlServer")!;

// Configura autenticazione e autorizzazione
builder.Services
    .AddAuthentication(opt =>
    {
        opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        opt.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(opt =>
    {
        opt.LoginPath = "/Account/Login";
        opt.AccessDeniedPath = "/Account/AccessDenied"; // Opzionale, ma utile per gestire gli accessi negati
    });

builder.Services
    .AddDbContext<DataContext>(opt => opt.UseSqlServer(conn))
    .AddTransient<IPizze, Pizze>()
    .AddTransient<IIngredienti, Ingredienti>()
    .AddTransient<IOrder, OrderSer>();


var app = builder.Build();

// Configura la pipeline delle richieste HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseRouting();

app.UseAuthentication(); // Assicurati che questo venga chiamato prima di UseAuthorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
