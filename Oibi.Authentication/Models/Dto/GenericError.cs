namespace Oibi.Authentication.Models.Dto
{
    public class GenericError
    {
        public GenericError(string message)
        {
            Message = message;
        }

        public string Code { get; set; }
        public string Message { get; set; }
    }
}