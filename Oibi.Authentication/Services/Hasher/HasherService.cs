using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Oibi.Authentication.Services
{
    /// <inheritdoc/>
    public class HasherService : IHasherService
    {
        private readonly IOptions<PasswordHasherOptions> _passwordHasherOptions;

        /// <inheritdoc/>
        public HasherService(IOptions<PasswordHasherOptions> passwordHasherOptions)
        {
            _passwordHasherOptions = passwordHasherOptions;
        }

        /// <inheritdoc/>
        public virtual string HashPassword<T>(T entity, string password) where T : class
        {
            var passwordHasher = new PasswordHasher<T>(_passwordHasherOptions);
            return passwordHasher.HashPassword(entity, password);
        }

        /// <inheritdoc/>
        public virtual PasswordVerificationResult VerifyHashedPassword<T>(T entity, string hashedPassword, string providedPassword)
             where T : class
        {
            var passwordHasher = new PasswordHasher<T>(_passwordHasherOptions);
            return passwordHasher.VerifyHashedPassword(entity, hashedPassword, providedPassword);
        }
    }
}