namespace BlazorExample.Server;

public class Program
{
public static void Main(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllers();

    // TODO: Add your own services.

    var app = builder.Build();
    if (app.Environment.IsDevelopment())
        app.UseWebAssemblyDebugging();

    app.UseHttpsRedirection();

    app.UseBlazorFrameworkFiles();
    app.UseStaticFiles();
    app.UseRouting();

    app.UseAuthorization();

    app.MapControllers();
    app.MapFallbackToFile("index.html");

    app.Run();
}
}