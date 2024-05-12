using Music_Manager.Logic.Logic_Interfaces;
using Music_Manager.Logic.Model_Logics;
using Music_Manager.Logic;
using Music_Manager.Models;
using Music_Manager.Repositories.Generic_Repository;
using Music_Manager.Repositories.ModelRepositories;
using Music_Manager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option
    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Music_ManagerDatabase;Trusted_Connection=True;MultipleActiveResultSets=true")
    .UseLazyLoadingProxies();
});

builder.Services.AddIdentity<SiteUser, IdentityRole>(option =>
{
    option.Password.RequiredLength = 3;
    option.Password.RequireNonAlphanumeric = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<ApplicationDbContext>();

builder.Services.AddTransient<IRepository<Albums>, AlbumsRepository>();
builder.Services.AddTransient<IRepository<Artists>, ArtistsRepository>();
builder.Services.AddTransient<IRepository<Ratings>, RatingsRepository>();

builder.Services.AddTransient<IAlbumLogic, AlbumLogic>();
builder.Services.AddTransient<IArtistLogic, ArtistLogic>();
builder.Services.AddTransient<IRatingLogic, RatingLogic>();
builder.Services.AddTransient<INonCrudLogic, NonCrudLogic>();

builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme
    ;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme
    ;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme
    ;
}).AddJwtBearer
(options =>
{
    options.SaveToken = true
    ;
    options.RequireHttpsMetadata = true
    ;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = "http://www.security.org",
        ValidIssuer = "http://www.security.org",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"))
    };
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "AllowOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
        });

    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithHeaders("");
            policy.WithOrigins("");
            policy.WithMethods("*");
        });
});




builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
