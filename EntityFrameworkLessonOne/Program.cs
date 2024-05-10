
using EntityFrameworkLessonOne.DatabaseFolder;
using EntityFrameworkLessonOne.Serviecs;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLessonOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql("Server=127.0.0.1;Port=5433;Database=OlatopDB;User Id=postgres;Password=2345;");
            });

            builder.Services.AddScoped<IProductService, ProductService>();  
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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
