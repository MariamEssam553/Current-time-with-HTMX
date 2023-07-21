var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/current-time", () =>
{
    var response = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    return Results.Ok(response);
});

app.Run();