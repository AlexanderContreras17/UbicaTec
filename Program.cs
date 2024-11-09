var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();
//context de bd



var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();//mapea las pag razor
app.MapControllers();//mapea los controladores
app.Run();
