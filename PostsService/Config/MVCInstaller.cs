using System;

namespace PostsService.Config
{
    public class MVCInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc();

            services.AddSwaggerGen(x => x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
            {
                Description = "Posts service",
                Title = "Posts",
                Version = "v1"
            }));
        }
    }
}

