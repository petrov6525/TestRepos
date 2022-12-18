var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(options => options.RootDirectory = "/MyPages");
var app = builder.Build();
app.MapRazorPages();


app.Run();
