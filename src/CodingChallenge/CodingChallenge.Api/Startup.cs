using FluentValidation;
using Journi.CodingChallenge.Api.Filters;
using Journi.CodingChallenge.Api.Middleware;
using Journi.CodingChallenge.Core.UseCases.Headphone.CreateHeadphone;
using Journi.CodingChallenge.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace Journi.CodingChallenge.Api
{
    public class Startup
    {
        readonly string allowSpecificOrigins = "_allowSpecificOrigins";
        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment environment;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            this.environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: allowSpecificOrigins, builder =>
                {
                    builder.WithOrigins(Configuration["Cors:AllowedOrigins"]?.Split(','));
                });
            });

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorPipelineBehaviour<,>));

            AssemblyScanner.FindValidatorsInAssembly(typeof(CreateHeadphoneCommandValidator).Assembly)
                .ForEach(item => services.AddScoped(item.InterfaceType, item.ValidatorType));

            services.AddControllers()
                .AddJsonOptions(opt =>
                {
                    opt.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
                    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Journi Coding Challenge Api", Version = "v1" });
                c.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(Startup).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(CreateHeadphoneCommand).Assembly);
            });

            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
            });

            services.AddHealthChecks();
            services.AddHttpContextAccessor();
            services.AddInfrastructureBindings(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            bool disableMigration = Configuration.GetValue<bool>("DisableMigration");
            if (!disableMigration)
            {
                MigrateDatabase(app);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("v1/swagger.json", "Coding Challenge Api V1");
                });
            }

            app.AddExceptionHandling();

            app.UseRouting();

            app.UseCors(allowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/api/health");
                endpoints.MapControllers();
            });
        }

        private static void MigrateDatabase(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<CodingChallengeDbContext>();
            context.Database.Migrate();
        }
    }
}
