using Oibi.Authentication.Demo;
using Oibi.Authentication.Services;
using Oibi.TestHelper;
using Xunit;

namespace Oibi.Authentication.XUnitTest
{
    public class HasherTests : IClassFixture<ServerFixture<Startup>>
    {
        private readonly ServerFixture<Startup> _serverFixture;
        private readonly IHasherService _hasherService;

        public HasherTests(ServerFixture<Startup> serverFixture)
        {
            _serverFixture = serverFixture;
            _hasherService = _serverFixture.GetService<IHasherService>();
        }

        [Theory]
        [InlineData("password1")]
        [InlineData("2222qwerty")]
        [InlineData("")]
        public void Test1(string plainPassword)
        {
            var o = new object();

            var hashed = _hasherService.HashPassword(o, plainPassword);
            var result = _hasherService.VerifyHashedPassword(o, hashed, plainPassword);

            Assert.Equal(Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success, result);
        }
    }
}