namespace StarSecurityServices.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string EducationalQualification { get; set; } = string.Empty;

        public string RoleId { get; set; } = string.Empty;

        public Role Role { get; set; } = new();

        public string BranchId {  get; set; } = string.Empty;

        public Branch Branch { get; set; } = new();
    }
}
