using Microsoft.Extensions.DependencyInjection;
using Application.Services.StudentServices;
using Application.Services.ClassServices;
namespace Application.DependencyInjection
{

 public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IClassService, ClassService>();


            return services;
        }
    }


}