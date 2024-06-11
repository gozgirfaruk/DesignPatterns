using Observer.UI.DAL;
using Observer.UI.ObserverPattern;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ObserverContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<ObserverContext>();
builder.Services.AddSingleton<ObserverObject>(serviceProvider =>
{
    ObserverObject observerObject = new();
    observerObject.RegisterObserver(new CreateWelcomeMessage(serviceProvider));
    observerObject.RegisterObserver(new CreateMagazineAnnouncement(serviceProvider));
    observerObject.RegisterObserver(new CreateDiscountCode(serviceProvider));
    return observerObject;
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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
