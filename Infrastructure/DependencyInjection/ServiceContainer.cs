using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Repositories;
namespace Infrastructure.DependencyInjection
{
     public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ATTENDCON"))
            );
            services.AddScoped<IStudent, StudentRepository>();

            services.AddScoped<IClasses, ClassesRepository>();

            services.AddScoped<IAttendance, AttendanceRepository>();

            services.AddScoped<IClassStudent, ClassStudentRepository>();

            services.AddScoped<IEducationLevel, EducationLevelRepository>();


            return services;
        }
    }
}