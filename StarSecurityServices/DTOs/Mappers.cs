using StarSecurityServices.DTOs.Achievements;
using StarSecurityServices.DTOs.Branches;
using StarSecurityServices.DTOs.Clients;
using StarSecurityServices.DTOs.Contracts;
using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.DTOs.EducationalQualifications;
using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.DTOs.Grades;
using StarSecurityServices.DTOs.Services;

namespace StarSecurityServices.DTOs
{
    public class Mappers
    {
        public AchievementDTO.Mapper AchievementDTOMapper => new();

        public BranchDTO.Mapper BranchDTOMapper => new();

        public ClientDTO.Mapper ClientDTOMapper => new();

        public ContractDTO.Mapper ContractDTOMapper
            => new(
                ClientDTOMapper,
                EmployeeDTOMapper,
                ServiceDTOMapper
            );

        public DepartmentDTO.Mapper DepartmentDTOMapper
            => new(BranchDTOMapper);

        #region EducationalQualifications

        public EducationalQualificationDTO.Mapper
            EducationalQualificationDTOMapper => new();

        #endregion

        #region Employees

        public EmployeeDTO.Mapper EmployeeDTOMapper => new(this);

        #endregion

        #region Grades

        public GradeDTO.Mapper GradeDTOMapper => new();

        #endregion

        public ServiceDTO.Mapper ServiceDTOMapper => new();
    }
}
