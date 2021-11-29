using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddSignalR();
app.MapHub<MyHub>("/chat");

app.MapGet("/", () => "Hello World!");

app.Run();

public class MyHub : Hub
{
    public async IAsyncEnumerable<DateTime>
}