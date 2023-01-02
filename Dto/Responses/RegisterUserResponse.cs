namespace MEalAPI.Dto.Responses
{
    public class RegisterUserResponse
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
