namespace StarSecurityServices.DTOs.Auth
{
    public class UpdatePasswordRequest
    {
        public string Code { get; set; } = string.Empty;

        public string OldPassword { get; set; } = string.Empty;

        public string NewPassword { get; set; } = string.Empty;

        public string ConfirmPassword { get; set;} = string.Empty;
    }
}
