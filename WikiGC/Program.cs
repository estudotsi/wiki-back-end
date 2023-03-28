using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WikiGC.Data;
using WikiGC.Repositories.Interface;
using WikiGC.Repositories.Repository;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var key = Encoding.ASCII.GetBytes("foolwrwnj&$¨&*sdPa@d");
builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        // configurar na aplicação o formaro JWTBearer
    }).AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true, // Validar a chave
            IssuerSigningKey = new SymmetricSecurityKey(key), // chave é simetrica 
            ValidateIssuer = false, // esse não precisa validar , pois é para quando a gente quer distribuir nossa aplicação
            ValidateAudience = false // esse não precisa validar, pois é para quando a gente quer distribuir nossa aplicação
        };
});

// Add services to the container.
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddTransient<IPortaisRepository, PortaisRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
