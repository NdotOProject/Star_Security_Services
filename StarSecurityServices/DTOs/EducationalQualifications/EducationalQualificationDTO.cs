using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.EducationalQualifications
{
    public class EducationalQualificationDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper : AbstractMapper<
            EducationalQualification, EducationalQualificationDTO>
        {
            public override EducationalQualificationDTO Map(
                EducationalQualification educational)
            {
                return new EducationalQualificationDTO
                {
                    Id = educational.Id,
                    Description = educational.Description,
                    Name = educational.Name,
                };
            }
        }
    }
}
