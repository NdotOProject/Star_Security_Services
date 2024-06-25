using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Clients
{
    public class CreateClientDTO
    {
        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public class Mapper
        {
            public Client Map(CreateClientDTO dto)
            {
                return new Client
                {
                    Email = dto.Email,
                    Name = dto.Name,
                    PhoneNumber = dto.PhoneNumber,
                };
            }
        }
    }
}
