using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                o =>
                {
                    o.SwaggerDoc("v1", new OpenApiInfo { Title = "team.blue test API", Version = "v1" });
                });

            return services;
        }

        public static IApplicationBuilder UseSwagger(this IApplicationBuilder app)
        {
            SwaggerBuilderExtensions.UseSwagger(app);
            app.UseSwaggerUI(
                o =>
                {
                    o.SwaggerEndpoint("/swagger/v1/swagger.json", "team.blue test API V1");
                    o.RoutePrefix = string.Empty;
                });

            return app;
        }
    }
}
