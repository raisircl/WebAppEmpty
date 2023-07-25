var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
 
    context.Response.StatusCode = 200;
    context.Response.ContentType = "text/html";
    context.Response.WriteAsync("<h1>Hello User</h1>");

    if (context.Request.Query.ContainsKey("n1") && context.Request.Query.ContainsKey("n2") && context.Request.Query.ContainsKey("op"))
    {
        var x = context.Request.Query["n1"].ToString();
        var y = context.Request.Query["n2"].ToString();
        var op = context.Request.Query["op"].ToString();
    if (op == "add")
    {
        int n1 = Convert.ToInt32(x);
        int n2 = Convert.ToInt32(y);
        int r = n1 + n2;
        context.Response.WriteAsync($"Sum of {x} and {y} is {r}");
    }
    }

});

app.Run();
