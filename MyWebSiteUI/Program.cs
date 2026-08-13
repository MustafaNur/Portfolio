using Core.Interfaces;
using DataAccess.Context;
using Business;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Business.Interfaces;
using Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Connection String okuma
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext Servis Kaydı (PostgreSQL için)
builder.Services.AddDbContext<PortfolioContext>(options =>
    options.UseNpgsql(connectionString));
    
// Repository ve Servis Enjeksiyonları
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IBiographyService, BiographyManager>();
builder.Services.AddScoped<ICertificateService, CertificateManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<ISkillService, SkillManager>();


// wwwroot klasörünü fiziksel çalışma dizinine açıkça bağlayın
builder.WebHost.UseWebRoot(Path.Combine(builder.Environment.ContentRootPath, "wwwroot"));
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
// Statik dosyaların (wwwroot) dışarıya sunulmasını sağlar
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
