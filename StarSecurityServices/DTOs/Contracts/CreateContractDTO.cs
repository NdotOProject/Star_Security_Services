namespace StarSecurityServices.DTOs.Contracts
{
    public class CreateContractDTO
    {
        public string Client { get; set; } = string.Empty;

        public ICollection<string> Employees { get; set;} = [];

        public ICollection<string> Services { get; set; } = [];
    }
}
