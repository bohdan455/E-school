using Database.Repositories.Interfaces;
using Database.Repositories.Realization.Main;

namespace Api.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IMarkRepository, MarkRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentSubjectRepository, StudentSubjectRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            return services;
        }
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
