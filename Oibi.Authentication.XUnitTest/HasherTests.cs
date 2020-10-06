using Microsoft.AspNetCore.Identity;
using Oibi.Authentication.Demo;
using Oibi.Authentication.Demo.Models;
using Oibi.TestHelper;
using Xunit;

namespace Oibi.Authentication.XUnitTest
{
    public class HasherTests : IClassFixture<ServerFixture<Startup>>
    {
        private readonly ServerFixture<Startup> _serverFixture;
        private readonly IPasswordHasher<DummyUser> _passwordHasher;

        public HasherTests(ServerFixture<Startup> serverFixture)
        {
            _serverFixture = serverFixture;
            _passwordHasher = _serverFixture.GetService<IPasswordHasher<DummyUser>>();
        }

        [Theory]
        [InlineData("password1")]
        [InlineData("dummystring123456789dummystring123456789dummystring123456789dummystring123456789dummystring123456789dummystring123456789")]
        [InlineData("")]
        public void Test1(string plainPassword)
        {
            var o = new DummyUser();

            var hashed = _passwordHasher.HashPassword(o, plainPassword);
            var result = _passwordHasher.VerifyHashedPassword(o, hashed, plainPassword);

            Assert.Equal(Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success, result);
        }
    }
}