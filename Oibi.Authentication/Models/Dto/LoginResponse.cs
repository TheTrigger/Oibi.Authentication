namespace Oibi.Authentication.Models.Dto
{
    public class LoginResponse : StateResponse
    {
        /// <summary>
        /// Authentication token
        /// </summary>
        public string Token { get; set; }
    }

    /// <summary>
    /// Login response. <see cref="TData"/> could be your user dto or your error type
    /// </summary>
    public class LoginResponse<TData> : StateResponse
    {
        public TData Data { get; set; }
    }
}