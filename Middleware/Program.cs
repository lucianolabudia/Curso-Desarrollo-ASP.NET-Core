var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


// ==== EJEMPLO DE MIDDLEWARE 5.0

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Este es mi primer Middleware");
    await next();
});



app.Run(async (context) =>
{
    await context.Response.WriteAsync("Este es mi primer Middleware");
});


app.Run();
