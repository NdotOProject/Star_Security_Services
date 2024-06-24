using StarSecurityServices.Context;
using StarSecurityServices.DTOs.Achievements;
using StarSecurityServices.DTOs.Branches;
using StarSecurityServices.DTOs.Departments;
using StarSecurityServices.DTOs.Employees;

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

        public UpdateBranchDTO.Mapper UpdateBranchDTOMapper => new(dbContext);

        #endregion

        #region Clients


        #endregion

        #region Departments

        public DepartmentDTO.Mapper DepartmentDTOMapper
        {
            get
            {
                return new(BranchDTOMapper);
            }
        }

        #endregion

        #region Employees

        public EmployeeDTO.Mapper EmployeeDTOMapper => new(dbContext);

        public CreateEmployeeDTO.Mapper CreateEmployeeDTOMapper => new(dbContext);

        #endregion

    }
}
