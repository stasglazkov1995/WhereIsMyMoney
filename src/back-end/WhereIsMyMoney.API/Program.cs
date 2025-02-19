using WhereIsMyMoney.BLL.Abstraction.Services;
using WhereIsMyMoney.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcCore();
builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient<IAuthService, AuthService>();

builder.Services.AddControllersWithViews().AddNewtonsoftJson();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen().AddSwaggerGenNewtonsoftSupport();


var app = builder.Build();

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
