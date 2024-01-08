
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();



app.UseStaticFiles();
app.UseAntiforgery();


app.Run();