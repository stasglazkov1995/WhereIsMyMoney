using WhereIsMyMoney.BLL.Abstraction.Services;
using WhereIsMyMoney.BLL.Services;
using WhereIsMyMoney.DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<WhereIsMyMoneyDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddMvcCore();
builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient<IAuthService, AuthService>();

builder.Services.AddControllersWithViews().AddNewtonsoftJson();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen().AddSwaggerGenNewtonsoftSupport();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WhereIsMyMoneyDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());
app.Run();
