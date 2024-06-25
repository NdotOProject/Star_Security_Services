using StarSecurityServices.Context;
using StarSecurityServices.DTOs.Achievements;
using StarSecurityServices.DTOs.Branches;
using StarSecurityServices.DTOs.Clients;
using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.DTOs.EducationalQualifications;
using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.DTOs.Grades;

namespace StarSecurityServices.DTOs
{
    public class Mappers(ApplicationDbContext dbContext)
    {
        #region Achievements

        public AchievementDTO.Mapper AchievementDTOMapper => new();

        public CreateAchievementDTO.Mapper
            CreateAchievementRequestMapper => new(dbContext);

        #endregion

        #region Branches

        public AddBranchDTO.Mapper AddBranchDTOMapper => new(dbContext);

        public BranchDTO.Mapper BranchDTOMapper => new();

        public UpdateBranchDTO.Mapper UpdateBranchDTOMapper
            => new(dbContext);

        #endregion

        #region Clients

        public ClientDTO.Mapper ClientDTOMapper => new();

        public CreateClientDTO.Mapper CreateClientDTOMapper => new();

        public UpdateClientDTO.Mapper UpdateClientDTOMapper
            => new(dbContext);

        #endregion

        #region Departments

        public DepartmentDTO.Mapper DepartmentDTOMapper
            => new(BranchDTOMapper);

        #endregion

        #region Employees

        public EmployeeDTO.Mapper EmployeeDTOMapper
            => new(
                DepartmentDTOMapper,
                EducationalQualificationDTOMapper,
                GradeDTOMapper
            );

        public CreateEmployeeDTO.Mapper CreateEmployeeDTOMapper
            => new(dbContext);

        #endregion

        #region EducationalQualifications

        public EducationalQualificationDTO.Mapper
            EducationalQualificationDTOMapper => new();

        #endregion

        #region Grades

        public GradeDTO.Mapper GradeDTOMapper => new();

        #endregion
    }
}
