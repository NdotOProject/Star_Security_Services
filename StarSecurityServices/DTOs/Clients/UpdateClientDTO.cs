using StarSecurityServices.Context;
using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Clients
{
    public class UpdateClientDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public class Mapper(ApplicationDbContext dbContext)
        {
            public async Task<Client> Map(UpdateClientDTO dto)
            {
                var client = await dbContext.Clients.FindAsync(dto.Id)
                    ?? throw new Exception();

                return new Client
                {
                    Id = client.Id,
                    Email = dto.Email,
                    Name = dto.Name,
                    PhoneNumber = dto.PhoneNumber,
                    Contracts = client.Contracts,
                };
            }
        }
    }
}
