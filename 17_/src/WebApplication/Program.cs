var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/novo_teste", () => getTeste());

app.MapGet("/novo_eu", () => new Client("Jr", "email@hotmail.com"));


app.Run();


String getTeste()
{
    return "Teste";
}

public record Client(string Nome, string Email);

