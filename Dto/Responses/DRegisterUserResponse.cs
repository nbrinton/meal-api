namespace MEalAPI.Dto.Responses
{
    public class DRegisterUserResponse
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
