using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Services
{
    public class ServiceDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper : AbstractMapper<Service, ServiceDTO>
        {
            public override ServiceDTO Map(Service service)
            {
                return new ServiceDTO
                {
                    Id = service.Id,
                    Description = service.Description,
                    Name = service.Name,
                };
            }
        }
    }
}
