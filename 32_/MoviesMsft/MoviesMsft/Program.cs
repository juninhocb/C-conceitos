using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesMsft.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MoviesMsftContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesMsftContext") ?? throw new InvalidOperationException("Connection string 'MoviesMsftContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();  //wwwroot -> bootstrap, javascript e etc. Pode-se apontar ao wwwroot, utilizando o caractere '~'
//i.e: <img src="~/images/MyImage.jpg" class="img" alt="My image" />
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles"))
});
//podem ser configuradas autoriza��es de acesso a estes recursos - como servi�o. 
/*
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});
 */



app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    
// rota adicional ao App 
app.MapGet("/hello", () => "Hello World!");

app.Run();
