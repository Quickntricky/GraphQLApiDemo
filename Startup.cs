using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GraphQLApi.GraphQL;
using GraphQL;
using GraphQL.Types;

namespace GraphQLApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ApiSchema>();
            services.AddScoped<ISchema>(sp => sp.GetRequiredService<ApiSchema>());
            services.AddGraphQL(service =>
                service.AddSystemTextJson()
                .AddGraphTypes(typeof(ApiSchema).Assembly));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
            app.UseGraphQLGraphiQL();
        }
    }
}