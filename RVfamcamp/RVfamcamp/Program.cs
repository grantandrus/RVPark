using RVfamcamp.Configuration;
using RVfamcamp.Database;
using RVfamcamp.Services;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<StripeSettings>(
    builder.Configuration.GetSection("Stripe")
);

builder.Services.Configure<AppSettings>(
	builder.Configuration.GetSection("App")
);

builder.Services.AddScoped<StripeService>();
builder.Services.AddSingleton<PaymentRepo>(); // TODO: Changed back to AddScoped once I connect this Repo to the real data base

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.Configure<StripeSettings>(
	builder.Configuration.GetSection("Stripe")
);

// For database
AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
var app = builder.Build();

var stripeSettings =
	builder.Configuration.GetSection("Stripe").Get<StripeSettings>();

var appSettings = builder.Configuration.GetSection("app").Get<AppSettings>();

StripeConfiguration.ApiKey = stripeSettings.SecretKey;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.MapControllers();

app.Run();
