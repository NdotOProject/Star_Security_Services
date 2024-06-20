namespace StarSecurityServices.Models.Common
{
    public interface IStringKeyEntity
    {
        string? Id { get; set; }

        static bool Generate(IStringKeyEntity obj)
        {
            if (obj.Id != null)
            {
                return string.IsNullOrWhiteSpace(obj.Id);
            }

            string id = Guid.NewGuid().ToString();

            obj.Id = id;

            return obj.Id == id;
        }
    }
}
