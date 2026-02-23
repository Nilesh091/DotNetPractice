var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enables default file mapping (like index.html)
app.UseDefaultFiles();

// Enables static file serving
app.UseStaticFiles();

// Optional: remove this if you want only index.html to load
// app.MapGet("/", () => "Hello World!");

app.Run();