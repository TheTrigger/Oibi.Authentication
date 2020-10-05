namespace Oibi.Authentication.Models.Dto
{
    /// <summary>
    /// Registration response. <see cref="TData"/> could be your user dto or your error type
    /// </summary>
    public class RegistrationResponse<TData> : StateResponse
    {
        public TData Data { get; set; }
    }
}