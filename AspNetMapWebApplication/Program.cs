var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//1
app.Map("/time", appBuilder =>
{
    var time = DateTime.Now.ToShortTimeString();
    appBuilder.Use(async (context, next) =>
    {
        Console.WriteLine($"Time: {time}");
        await next();
    });
    appBuilder.Run(async context => await context.Response.WriteAsync($"Time: {time}"));
});

app.Map("/time", appBuilder =>
{
    var time = DateTime.Now.ToShortTimeString();
    appBuilder.Use(async (context, next) =>
    {
        Console.WriteLine($"Time: {time}");
        await next();
    });
    appBuilder.Run(async context => await context.Response.WriteAsync($"Time: {time}"));
});

app.Run(async (context) => await context.Response.WriteAsync("Home page"));


// 2
//app.Map("/index", appBuilder =>
//{
//    appBuilder.Run(async context => await context.Response.WriteAsync("Index Page"));
//});
//app.Map("/about", appBuilder =>
//{
//    appBuilder.Run(async context => await context.Response.WriteAsync("About Page"));
//});

//app.Run(async (context) => await context.Response.WriteAsync("Page Not Found"));

//3
//app.Map("/home", appBuilder =>
//{
//    appBuilder.Map("/index", Index); // middleware для "/home/index"
//    appBuilder.Map("/about", About); // middleware для "/home/about"
//    // middleware для "/home"
//    appBuilder.Run(async (context) => await context.Response.WriteAsync("Home Page"));
//});

//app.Run(async (context) => await context.Response.WriteAsync("Page Not Found"));

app.Run();


// 3
//void Index(IApplicationBuilder appBuilder)
//{
//    appBuilder.Run(async context => await context.Response.WriteAsync("Index Page"));
//}
//void About(IApplicationBuilder appBuilder)
//{
//    appBuilder.Run(async context => await context.Response.WriteAsync("About Page"));
//}
