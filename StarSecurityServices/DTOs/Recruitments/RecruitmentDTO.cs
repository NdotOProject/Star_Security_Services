using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Recruitments
{
    public class RecruitmentDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public EmployeeDTO Manager { get; set; } = new();

        public string Title { get; set; } = string.Empty;

        public string Vacancies { get; set; } = string.Empty;

        public class Mapper(EmployeeDTO.Mapper employeeDTOMapper)
            : AbstractMapper<Recruitment, RecruitmentDTO>
        {
            public override RecruitmentDTO Map(Recruitment o)
            {
                return new RecruitmentDTO
                {
                    Id = o.Id,
                    Description = o.Description,
                    Manager = employeeDTOMapper
                        .Map(o.Manager),
                    Title = o.Title,
                    Vacancies = o.Vacancies,
                };
            }
        }
    }
}
