namespace StarSecurityServices.DTOs.Recruitments
{
    public class CreateRecruitmentDTO
    {
        public string Description { get; set; } = string.Empty;

        public string ManagerId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Vacancies { get; set; } = string.Empty;
    }
}
