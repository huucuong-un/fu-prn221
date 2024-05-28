using DiamondPlaze.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Reso.Core.Extension;
using System.Text;
using System.Text.Json.Serialization;
using DiamondPlaza.Services;
using DiamondPlaza.Services.Handlers;

var builder = WebApplication.CreateBuilder(args);

#region CORS Policy
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
#endregion

#region Authentication
var tokenValidationParams = new TokenValidationParameters
{
    ValidateIssuer = false,
    ValidateAudience = false,
    ValidateLifetime = true,
    RequireExpirationTime = false,
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Secretkey"]))
};

builder.Services.AddSingleton(tokenValidationParams);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.SaveToken = true;
        opt.TokenValidationParameters = tokenValidationParams;
    });
builder.Services.AddMvc(opt =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddHttpContextAccessor();
#endregion

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});
builder.Services.AddDbContext<DiamondPlazeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.ConfigureFilter<ErrorHandlingFilter>();
builder.Services.JsonFormatConfig();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureDI();
builder.Services.ConfigureServiceWorkers();
builder.Services.ConfigDataProtection();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Uncomment and configure CORS as necessary
// app.MapHub<NotifyHub>("/notifyHub");
// app.Map("/notifyHub", map =>
// {
//     map.UseCors(MyAllowSpecificOrigins);
// });

app.MapControllers();

app.Run();
