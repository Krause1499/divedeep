using Microsoft.EntityFrameworkCore;
using DiveDeep.Data;
using DiveDeep.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DiveDeepContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDBConnection") ?? throw new InvalidOperationException("Connection string 'MyDBConnection' not found.")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DiveDeepContext>();
    context.Database.Migrate();
    DbInitializer.Seed(context);
}
app.Run();
