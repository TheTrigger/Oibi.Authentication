namespace Oibi.Authentication.Models.Dto
{
    /// <inheritdoc/>
    public abstract class StateResponse : IStateResponse
    {
        /// <inheritdoc/>
        public bool Success { get; set; }
    }
}