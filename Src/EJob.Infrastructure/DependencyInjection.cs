using EJob.Domain.Interfaces;
using EJob.Domain.RepositoryContacts;
using EJob.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EJob.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<IDocumentRepository, DocumentRepository>();
            services.AddTransient<IUnitOfWork, EJobDbContext>();
            services.AddDbContext<EJobDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                assembly => assembly.MigrationsAssembly(typeof(EJobDbContext).Assembly.FullName))
            );
            return services;
        }
    }
}
