using Microsoft.Extensions.DependencyInjection;

namespace Oibi.Authentication.Extensions
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add default password hasher service to given <see cref="IServiceCollection"/>
        /// </summary>
        public static IServiceCollection AddPasswordHasher<TUser>(this IServiceCollection services) where TUser : class
        {
            services.AddHttpContextAccessor();
            services.AddIdentityCore<TUser>();

            return services;
        }
    }
}