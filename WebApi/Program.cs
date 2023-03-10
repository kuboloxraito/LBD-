using Application.Interfaces;
using Application.Services;
using DataAccess.Interfaces;
using DataAccess.Models;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Application.Mapping.AutoMapper.Configure);
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IRatingRepository, RatingRepository>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IRecomendationRepository, RecomendationRepository>();
builder.Services.AddScoped<IRecomendationService, RecommendationService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(typeof(MovieService));
builder.Services.AddMediatR(typeof(RatingService));
builder.Services.AddMediatR(typeof(CommentService));
builder.Services.AddMediatR(typeof(RecommendationService));

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(x=>x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();