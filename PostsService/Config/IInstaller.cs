using System;
using Microsoft.Extensions.Configuration;

namespace PostsService.Config
{
    public interface IInstaller
    {
        void InstallService(IServiceCollection services, IConfiguration configuration);
    }
}

