using Journi.CodingChallenge.Core.Interfaces;
using Journi.CodingChallenge.Infrastructure.Repository.Headphone;
using Journi.CodingChallenge.Infrastructure.Repository.Keyboard;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Journi.CodingChallenge.Infrastructure
{
    public static class Startup
    {
        public static void AddInfrastructureBindings(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CodingChallengeDbContext>(opt =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                opt.UseSqlServer(connectionString, sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
                });
            });

            services.AddScoped<ICreateHeadphoneRepository, CreateHeadphoneRepository>();
            services.AddScoped<IGetHeadphoneRepository, GetHeadphoneRepository>();
            services.AddScoped<IGetHeadphonesRepository, GetHeadphonesRepository>();
            services.AddScoped<IUpdateHeadphoneRepository, UpdateHeadphoneRepository>();
            services.AddScoped<IDeleteHeadphoneRepository, DeleteHeadphoneRepository>();
            services.AddScoped<ICreateKeyboardRepository, CreateKeyboardRepository>();
            services.AddScoped<IGetKeyboardRepository, GetKeyboardRepository>();
            services.AddScoped<IGetKeyboardsRepository, GetKeyboardsRepository>();
            services.AddScoped<IUpdateKeyboardRepository, UpdateKeyboardRepository>();
            services.AddScoped<IDeleteKeyboardRepository, DeleteKeyboardRepository>();
        }
    }
}
