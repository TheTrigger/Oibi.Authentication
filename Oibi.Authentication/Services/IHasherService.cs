using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;

namespace Oibi.Authentication.Services
{
    /// <summary>
    /// Simple password hasher service 
    /// </summary>
    public interface IHasherService
    {
        /// <summary>
        /// Hash given password
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="entity">entity reference</param>
        /// <param name="password">plain password to hash</param>
        /// <returns>encrypted password</returns>
        string HashPassword<T>(T entity, string password) where T : class;

        /// <summary>
        /// Verify if plain <paramref name="providedPassword"/> is comparable to <paramref name="hashedPassword"/>
        /// </summary>
        /// <typeparam name="T">entity type</typeparam>
        /// <param name="entity">entity reference</param>
        /// <param name="hashedPassword">stored hashed password</param>
        /// <param name="providedPassword">plain password provided by user</param>
        /// <returns>Verification result</returns>
        PasswordVerificationResult VerifyHashedPassword<T>(T entity, string hashedPassword, string providedPassword) where T : class;
    }
}