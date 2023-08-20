using JupiterWeb.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using JupiterWeb.DAL;
using JupiterWeb.BL;


var builder = WebApplication.CreateBuilder(args);

//context registration 
/*builder.Services.AddIdentity<User, IdentityRole<string>>()
    .AddEntityFrameworkStores<SchoolDbContext>()
    .AddDefaultTokenProviders();*/
// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
    builder =>
    {
        builder.WithOrigins(
                            "http://localhost:4200"
                            )
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//connection String
var connectionString = builder.Configuration.GetConnectionString("SchoolConnection"); 
builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer(connectionString));
// Register our Repo
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<IStudentSubjectRepo, StudentSubjectRepo>();
builder.Services.AddScoped<ITotlGradeRepo,TotalGradeRepo>();
//builder.Services.AddAuthorization();


// Injection of UserManager 
builder.Services.AddScoped<IStudentManger,StudentManger>();
builder.Services.AddScoped<IStudentSubjectsManger, StudentSubjectsManger>();
builder.Services.AddScoped<ITotalGradesManger, TotalGradeManger>();

//// Authenticaction
////r secretKey = builder.Configuration.GetValue<string>("SecretKey");
////r secretKeyBytes = string.IsNullOrEmpty(secretKey) ? null : Encoding.ASCII.GetBytes(secretKey);
////r Key = new SymmetricSecurityKey(secretKeyBytes);

//builder.Services.AddAuthentication("default").AddJwtBearer("default", 
//    options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuer = false,
//            IssuerSigningKey = Key
//        };
//    }
//    );
var app = builder.Build();
app.UseCors("AllowAngularOrigins");
app.UseAuthentication();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
