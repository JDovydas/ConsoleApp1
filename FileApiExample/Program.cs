
using FileApiExample.Repositories.Interfaces;
using FileApiExample.Repositories;
using FileApiExample.Services.Interfaces;
using FileApiExample.Services;
using Microsoft.EntityFrameworkCore;

namespace FileApiExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IPhotoService, PhotoService>();
            builder.Services.AddScoped<IPhotoRepository, PhotoRepository>();
            builder.Services.AddScoped<IThumbnailService, ThumbnailService>();
            builder.Services.AddScoped<IThumbnailRepository, ThumbnailRepository>();
            builder.Services.AddDbContext<FileContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

            var app = builder.Build();

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
        }
    }
}
