using Microsoft.Extensions.DependencyInjection;
using Oibi.Authentication.Services;

namespace Oibi.Authentication.Extensions
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add simple password hasher service to given <see cref="IServiceCollection"/>
        /// </summary>
        public static IServiceCollection AddPasswordHasher(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IHasherService, HasherService>();

            return services;
        }
    }
}