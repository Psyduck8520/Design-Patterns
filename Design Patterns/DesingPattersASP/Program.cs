using DesingPattersASP.Configurations;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<MyConfig>(builder.Configuration.GetSection("MyConfig"));
builder.Services.AddTransient<LocalEarnfactory>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();

    var percentage = configuration
        .GetSection("MyConfig")
        .GetValue<decimal>("LocalPercentage");

    return new LocalEarnfactory(percentage);
});
builder.Services.AddTransient<ForeignEarnfactory>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();

    var percentage = configuration
        .GetSection("MyConfig")
        .GetValue<decimal>("ForeignPercentage");
    var extra = configuration
        .GetSection("MyConfig")
        .GetValue<decimal>("extra");
    
    return new ForeignEarnfactory(percentage,  extra);
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();