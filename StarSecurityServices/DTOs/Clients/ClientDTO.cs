using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Clients
{
    public class ClientDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public class Mapper
            : AbstractMapper<Client, ClientDTO>
        {
            public override ClientDTO Map(Client client)
            {
                return new ClientDTO
                {
                    Id = client.Id!,
                    Email = client.Email,
                    Name = client.Name,
                    PhoneNumber = client.PhoneNumber,
                };
            }
        }
    }
}
