using StarSecurityServices.DTOs.Clients;
using StarSecurityServices.DTOs.Employees;
using StarSecurityServices.DTOs.Services;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Contracts
{
    public class ContractDTO
    {
        public string Id { get; set; } = string.Empty;

        public ClientDTO Client { get; set; } = new();

        public IEnumerable<EmployeeDTO> Employees { get; set; } = [];

        public IEnumerable<ServiceDTO> Services { get; set; } = [];

        public class Mapper(
            ClientDTO.Mapper clientDTOMapper,
            EmployeeDTO.Mapper employeeDTOMapper,
            ServiceDTO.Mapper serviceDTOMapper)
        {
            public ContractDTO Map(Contract contract)
            {
                return new ContractDTO
                {
                    Id = contract.Id!,
                    Client = clientDTOMapper.Map(contract.Client),
                    Employees = contract.Employees.Select(employeeDTOMapper.Map),
                    Services = contract.Services.Select(serviceDTOMapper.Map)
                };
            }
        }
    }
}
